using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using XRvRentPlus.Models;

namespace XRvRentPlus.ViewModels
{
    public class RandomRvViewModel
    {
        public Rv Rv { get; set; }
        public Customer Customer { get; set; }
        public List<Rv> Rvs { get; set; }
        public List<Customer> Customers { get; set; }

    }  
}