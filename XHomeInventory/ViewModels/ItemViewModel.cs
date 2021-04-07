using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XHomeInventory.ViewModels
{
    public class ItemViewModel
    {
        public int Id { get; set; }

        public string SerialNo { get; set; }

        public string Model { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }

        public HttpPostedFileBase Photo { get; set; }
        public byte[] PhotoDB { get; set; }

        [DataType(DataType.Date)]
        public DateTime When { get; set; }

        public string Where { get; set; }

        public int Warranty { get; set; }

        public double Price { get; set; }
    }
}