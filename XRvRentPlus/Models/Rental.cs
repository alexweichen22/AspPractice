using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XRvRentPlus.Models
{
    public class Rental
    {
        public int Id { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public Rv Rv { get; set; }

        public DateTime DateBooked { get; set; }
        public DateTime DateRentStart { get; set; }
        public DateTime DateRentEnd { get; set; }

    }
}