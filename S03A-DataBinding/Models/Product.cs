using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace X02b_DataBinding.Models
{
    public class Product
    {        
            [Key]
            public int Id { get; set; }

            [StringLength(100)]
            public string Name { get; set; }

            [StringLength(255)]
            public string Description { get; set; }
        }
}