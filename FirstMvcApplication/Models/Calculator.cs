using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstMvcApplication.Models
{
    public class Calculator
    {

        [Range(1, 100)]
        [Display(Name ="Number 1")]
        public int Operand1 { get; set; }

        [Range(1, 100)]

        [Display(Name = "Number 2")]
        public int Operand2 { get; set; }

        [Required]
        public Operator Operator { get; set; }
        public double? Result { get; set; }
    }
}