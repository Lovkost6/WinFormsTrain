using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsTrain.Models
{
    internal class HRDContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public HRDContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=HRD;Trusted_Connection=Trus;TrustServerCertificate=Trus;");
        }
    }
}
