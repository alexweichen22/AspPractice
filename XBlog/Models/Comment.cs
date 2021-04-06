using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XBlog.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Display(Name = "Creation Date")]
        public DateTime CreatedOn { get; set; }

        [Display(Name = "Modification Date")]
        public DateTime UpdatedOn { get; set; }

        [StringLength(255)]
        [Display(Name = "Commented By")]
        public string UserFullName { get; set; }

        [Required]
        [Display(Name = "Post")]
        public int PostId { get; set; }

        [Display(Name = "is Published?")]
        public bool IsPublished { get; set; }

        public Post Post { get; set; }
    }
}