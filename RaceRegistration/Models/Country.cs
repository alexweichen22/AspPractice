using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RaceRegistration.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }
    }
}