using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoomingSoonApp.Models
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }
        public DateTime RequestDate { get; set; } = DateTime.Now;
        public string Name { get; set; } = "UnKnown";
        public string Message { get; set; } = "UnKnown";
        public string Email { get; set; } = "UnKnown";
    }
}