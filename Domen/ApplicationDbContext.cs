using Domen.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Osoba> Osobe { get; set; }
        public DbSet<Zaposleni> Zaposleni { get; set; }
        public DbSet <Administrator> Administratori { get; set; }
        
    }
}
