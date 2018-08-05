using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelWebApi.Models
{
    public class Root2
    {
        public List<Hotel>Results { get; set; }

        public string status { get; set; }
    }
}