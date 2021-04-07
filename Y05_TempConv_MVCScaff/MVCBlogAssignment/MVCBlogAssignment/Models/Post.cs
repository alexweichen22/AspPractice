using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBlogAssignment.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        //[StringLength(255)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Display(Name = "Creation Date")]
        public DateTime CreatedOn { get; set; }

        [Display(Name = "Modification Date")]
        public DateTime UpdatedOn { get; set; }

        [Display(Name = "Publication Date")]
        public DateTime? PostedOn { get; set; }

        [StringLength(255)]
        [Display(Name = "Posted By")]
        public string UserFullName { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}