using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using HotelWebApi.Models;
using System.Web.Http.Results;

namespace HotelWebApi.Controllers
{
    public class HotelWebApiController : ApiController
    {

        [HttpGet]

        public JsonResult<List<Hotel>> GET([FromUri]string input)

        {
            var result = new WebClient().DownloadString("https://maps.googleapis.com/maps/api/place/autocomplete/json?input=" + input + "&types=geocode&language=en&key=AIzaSyD_Fa4Q_FAW4265smq8rdj_lOlZc0Y_WOE");
            var Jsonobject = JsonConvert.DeserializeObject<Root>(result);
            List<prediction> autocomplete = Jsonobject.predictions;
            string place = autocomplete[0].description;
            var result1 = new WebClient().DownloadString("https://maps.googleapis.com/maps/api/place/textsearch/json?query=hotels+in+" + place + "&radius=10000&key=AIzaSyD_Fa4Q_FAW4265smq8rdj_lOlZc0Y_WOE");
            var Jsonobject1 = JsonConvert.DeserializeObject<Root2>(result1);
            List<Hotel> HotelList = Jsonobject1.Results;

            return Json(HotelList);
        }
    }
}
