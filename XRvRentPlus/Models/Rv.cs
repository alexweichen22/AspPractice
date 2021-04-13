using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XRvRentPlus.Models
{
    public class Rv
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}