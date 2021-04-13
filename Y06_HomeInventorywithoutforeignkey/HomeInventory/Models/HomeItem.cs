using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeInventory.Models
{
    public class HomeItem
    {
        [Key]
        public int HomeItemId { get; set; }

        [StringLength(100)]
        public string Model { get; set; }

        [StringLength(100)]
        [Display(Name = "Serial Number")]
        public string SerialNumber { get; set; }

        [Display(Name = "Location")]
        public int LocationId { get; set; }

        public Location Location { get; set; }

        public int PurchaseInfoId { get; set; }

        [Display(Name = "Purchase Info")]
        public PurchaseInfo PurchaseInfo { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        public byte[] Photo { get; set; }        
    }
}