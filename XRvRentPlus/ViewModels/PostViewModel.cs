using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XRvRentPlus.Models;

namespace XRvRentPlus.ViewModels
{
    public class PostViewModel
    {
        public Post Post { get; set; }
        public List<Comment> Comments { get; set; }
    }
}