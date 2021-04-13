using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeInventory.Models
{
    public class PurchaseInfo
    {
        [Key]
        public int PurchaseInfoId { get; set; }

        public DateTime? When { get; set; }

        [StringLength(255)]
        public string Where { get; set; }

        [StringLength(255)]
        public string Warranty { get; set; }
        
        public double? Price { get; set; }


    }
}