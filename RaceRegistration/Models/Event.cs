using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RaceRegistration.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [StringLength(150)]
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime EventDate { get; set; }

        [Display(Name="Is Closed?")]
        public bool IsClosed { get; set; }





    }
}