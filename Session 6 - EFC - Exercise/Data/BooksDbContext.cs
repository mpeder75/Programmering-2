using Microsoft.EntityFrameworkCore;
using Session_6___EFC___Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_6___EFC___Exercise.Data
{
    internal class BooksDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Michael-Pc;Database=Books;Trusted_Connection=True");
        }

    }
}
