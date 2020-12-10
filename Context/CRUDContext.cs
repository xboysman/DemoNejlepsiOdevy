using DemoNejlepsiOdevy.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoNejlepsiOdevy.Context
{
    public class CRUDContext : DbContext
    {
        public CRUDContext(DbContextOptions<CRUDContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
    }
}
