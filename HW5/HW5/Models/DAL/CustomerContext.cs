using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace HW5.DAL
{
    public class CustomerContext : DbContext
    {
        public CustomerContext() : base("name=CustomerDBContext")
        { }

        public virtual DbSet<Customer> Customers { get; set; }

    }
}