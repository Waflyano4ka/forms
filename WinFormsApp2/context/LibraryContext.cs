using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp2.models;

namespace WinFormsApp2.context
{
    public class LibraryContext : DbContext
    {
        public LibraryContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(ConfigurationManager.ConnectionStrings["DbConnections"].ConnectionString);
        }

        public DbSet<User> User { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Sheet> Sheet { get; set; }
    }
}
