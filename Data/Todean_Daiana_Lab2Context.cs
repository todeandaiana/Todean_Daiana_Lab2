using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Todean_Daiana_Lab2.Models;

namespace Todean_Daiana_Lab2.Data
{
    public class Todean_Daiana_Lab2Context : DbContext
    {
        public Todean_Daiana_Lab2Context (DbContextOptions<Todean_Daiana_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Todean_Daiana_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Todean_Daiana_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Todean_Daiana_Lab2.Models.Author> Author { get; set; }

        public DbSet<Todean_Daiana_Lab2.Models.Category> Category { get; set; }

        public DbSet<Todean_Daiana_Lab2.Models.Member> Member { get; set; }

        public DbSet<Todean_Daiana_Lab2.Models.Borrowing> Borrowing { get; set; }

     
    }
}
