using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session_7___Aflevering___Models;

namespace Session_7___Aflevering___DA
{
    internal class VaregruppeDbContext:DbContext
    {
        public DbSet<Vare> Varer { get; set; }
        public DbSet<Varegruppe> Varegrupper { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Michael-PC;Database=Varer;Trusted_Connection=True;").
                UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

    } 
}
