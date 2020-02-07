using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KVidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    //public class MyDBContext : DbContext
    //{
    //    public DbSet<Customer> customers { get; set; }
    //}
}