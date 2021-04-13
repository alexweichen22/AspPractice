using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace XRaceV1.Models
{
    public class Runner
    {
        [Key]
        public int RunnerId { get; set; }
        public string Name { get; set; }
        public byte[] Photo { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}