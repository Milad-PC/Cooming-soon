
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoomingSoonApp
{
    public class EmailReq
    {
        [Key]
        public int EmailReqId { get; set; }
        [Required]
        public DateTime ReqDate { get; set; } = DateTime.Now;
        public string EmailAddress { get; set; } = "UnKnown";
    }
}