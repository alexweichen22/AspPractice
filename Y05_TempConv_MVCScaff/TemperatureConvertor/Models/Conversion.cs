using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TemperatureConvertor.Models
{
    public class Conversion
    {
        public TemperatureUnit From { get; set; }

        public TemperatureUnit To { get; set; }

        public double ToConvert { get; set; }

        public string Result { get; set; }

    }
}