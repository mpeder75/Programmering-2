using Microsoft.EntityFrameworkCore;
using Session_6___EFC___Aflevering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_6___EFC___Aflevering.Data
{
    public class VareDbContext : DbContext
    {
        public DbSet<Vare> Vares { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Michael-Pc;Database=VareDb;Trusted_Connection=True;");
        }

    }
}

