using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Z05_MVC_auth.Models
{
    public class Vaccination
    {
        [Key]
        public int id { get; set; }

        public string brand { get; set; }

        public int shots { get; set; }


    }
}