using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WeatherApi.Models;

namespace WeatherApi.Controllers
{
    public class WeatherController : Controller
    {
        // GET: Weather
        public ActionResult Index()
        {
            return View(new WeatherViewModel());
        }

        [HttpPost]
        public ActionResult Index(string RequestedCity)
        {
            string appId = "1e447f1c7fee1e044947f13c1107e220";
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&cnt=1&APPID={1}", RequestedCity, appId);

            using (WebClient client = new WebClient())
            {
                string jsonResult = client.DownloadString(url);
                WeatherDto weatherDto = (new JavaScriptSerializer()).Deserialize<WeatherDto>(jsonResult);

                WeatherViewModel rslt = new WeatherViewModel();
                rslt.RequestedCity = RequestedCity;
                rslt.Country = weatherDto.sys.country;
                rslt.City = weatherDto.name;
                rslt.Lat = Convert.ToString(weatherDto.coord.lat);
                rslt.Lon = Convert.ToString(weatherDto.coord.lon);
                rslt.Description = weatherDto.weather[0].description;
                rslt.Humidity = Convert.ToString(weatherDto.main.humidity);
                rslt.Temp = Convert.ToString(weatherDto.main.temp);
                rslt.TempFeelsLike = Convert.ToString(weatherDto.main.feels_like);
                rslt.TempMax = Convert.ToString(weatherDto.main.temp_max);
                rslt.TempMin = Convert.ToString(weatherDto.main.temp_min);
                rslt.WeatherIcon = weatherDto.weather[0].icon;
                return View(rslt);
            }

           
        }


    }
}
