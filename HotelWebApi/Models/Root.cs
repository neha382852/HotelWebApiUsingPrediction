using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelWebApi.Models
{
    public class Root
    {
        public List<prediction> predictions { get; set; }
        //public List<Hotels> Hotels { get; set; }
        public string status { get; set; }
    }
}