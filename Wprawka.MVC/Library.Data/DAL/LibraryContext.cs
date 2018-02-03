using Library.Data.Entities;
using Library.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.DAL
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() 
            : base("Library") 
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LibraryContext, Configuration>());
        }

        public DbSet<User> User { get; set; }

        public DbSet<Book> Book { get; set; }

        public DbSet<DictBookGenre> DictBookGenre { get; set; }

        public DbSet<Borrow> Borrow { get; set; }
    }
}
