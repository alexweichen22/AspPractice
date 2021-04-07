using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WeatherApi.Models
{

    //this class I will use to show information in the view
    public class WeatherViewModel
    {
        [Display (Name = "City") ]
        public string RequestedCity { get; set; }

        public string City { get; set; }
        public string Country { get; set; }
        [Display(Name = "Latitud")]
        public string Lat { get; set; }
        [Display(Name = "Longitud")]
        public string Lon { get; set; }
        public string Description { get; set; }
        public string Humidity { get; set; }
        [Display(Name = "Feels Like")]
        public string TempFeelsLike { get; set; }
        [Display(Name = "Temperature")]
        public string Temp { get; set; }
        [Display(Name = "Temperature Max.")]
        public string TempMax { get; set; }
        [Display(Name = "Temperature Min.")]
        public string TempMin { get; set; }
        public string WeatherIcon { get; set; }
    }

    
}