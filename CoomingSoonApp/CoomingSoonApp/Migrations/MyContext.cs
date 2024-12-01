using CoomingSoonApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CoomingSoonApp
{
    public class MyContext : DbContext
    {
        public DbSet<Request> Requests { get; set; }
        public DbSet<EmailReq> EmailRequests { get; set; }
        public DbSet<Admins> Admins { get; set; }
    }
}