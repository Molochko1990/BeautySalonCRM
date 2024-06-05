using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mariya.Data
{
    public class SalonContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Master> Masters { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Visit> Visits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=salon.db");

            base.OnConfiguring(optionsBuilder);
        }

    }
}
