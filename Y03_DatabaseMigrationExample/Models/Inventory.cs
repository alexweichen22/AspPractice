using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatabaseMigrationExample.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }
    }
}