using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RaceRegistration.Models
{
    public class Runner
    {
        [Key]
        public int RunnerId { get; set; }

        [StringLength(100)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(100)]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Birth Date")]
        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [StringLength(50)]
        [Required]
        public string Email { get; set; }

        [StringLength(15)]
        [Required]
        public string Telephone { get; set; }

        [StringLength(255)]
        [Required]
        public string Address { get; set; }

        [StringLength(50)]
        [Required]
        public string State { get; set; }

        [Display(Name = "PostalCode")]
        [StringLength(15)]
        public string PostalCode { get; set; }

        [Display(Name = "Registration Date")]
        [Required]
        public DateTime RegistrationDate { get; set; }

        [Display(Name = "Country")]
        [Required]
        public int CountryId { get; set; }

        public Country Country { get; set; }

        [Display(Name = "ContactName")]
        [Required]
        public string ContactPersonName { get; set; }

        [Display(Name = "Contact Telephone")]
        [Required]
        public string ContactPersonTelephone { get; set; }

        [Display(Name = "Events")]
        [Required]
        public int EventId { get; set; }

        public Event Event { get; set; }

    }
}