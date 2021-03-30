using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TroisLacsBlog.Models
{
    public class Vaccination
    {
        [Key]
        public int id { set; get; }

        public string brand { set; get; }

    }
}