namespace Library.Data.Migrations
{
    using Library.Data.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Library.Data.DAL.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Library.Data.DAL.LibraryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.User.AddOrUpdate(p => p.UserID,
                 new User
                 {
                     UserID = 1,
                     FirstName = "Mateusz",
                     LastName = "Pawelski",
                     BirthDate = new DateTime(1991, 7, 17),
                     AddDate = new DateTime(2001, 3, 10),
                     Email = "mpawelski91@gmail.com",
                     Phone = "510135155",
                     IsActive = true
                 },
                 new User
                 {
                     UserID = 2,
                     FirstName = "Jan",
                     LastName = "Kowalski",
                     BirthDate = new DateTime(1988, 1, 12),
                     AddDate = new DateTime(2001, 3, 12),
                     Email = "dzony88@gmail.com",
                     Phone = "123123123",
                     IsActive = true
                 },
                 new User
                 {
                     UserID = 3,
                     FirstName = "Janina",
                     LastName = "Nowak",
                     BirthDate = new DateTime(1968, 12, 8),
                     AddDate = new DateTime(1998, 2, 7),
                     Email = "janka@gmail.com",
                     Phone = "987789987",
                     IsActive = true
                 });

            context.DictBookGenre.AddOrUpdate(d => d.BookGenreID,
                new DictBookGenre
                {
                    BookGenreID = 1,
                    Name = "Powiesc"
                },
                new DictBookGenre
                {
                    BookGenreID = 2,
                    Name = "Nowela"
                },
                new DictBookGenre
                {
                    BookGenreID = 3,
                    Name = "Poematy"
                },
                new DictBookGenre
                {
                    BookGenreID = 4,
                    Name = "Dramat"
                });

            context.Book.AddOrUpdate(b => b.BookID,
                new Book
                {
                    BookID = 1,
                    Author = "Henryk Sienkiewicz",
                    BookGenreID = 2,
                    ISBN = "1234567891012",
                    Title = "Latarnik",
                    AddDate = new DateTime(2000, 1, 1),
                    Count = 2,
                    ReleaseDate = new DateTime(1881, 1, 1),
                },
                new Book
                {
                    BookID = 2,
                    Author = "Juliusz S³owacki",
                    BookGenreID = 4,
                    ISBN = "9876543211314",
                    Title = "Balladyna",
                    AddDate = new DateTime(1998, 12, 6),
                    Count = 7,
                    ReleaseDate = new DateTime(1834, 1, 1),
                },
                new Book
                {
                    BookID = 3,
                    Author = "Julisz S³owacki",
                    BookGenreID = 1,
                    ISBN = "56987412308925",
                    Title = "Fantazy",
                    AddDate = new DateTime(2014, 6, 8),
                    Count = 10,
                    ReleaseDate = new DateTime(1844, 11, 11),
                },
                new Book
                {
                    BookID = 4,
                    Author = "Adam Mickiewicz",
                    BookGenreID = 3,
                    ISBN = "4716925830795",
                    Title = "Ballady i Romanse",
                    AddDate = new DateTime(2012, 1, 1),
                    Count = 6,
                    ReleaseDate = new DateTime(1882, 1, 1),
                },
                new Book
                {
                    BookID = 5,
                    Author = "Henryk Sienkiewicz",
                    BookGenreID = 1,
                    ISBN = "2345678901011",
                    Title = "Potop",
                    AddDate = new DateTime(2099, 12, 3),
                    Count = 13,
                    ReleaseDate = new DateTime(1886, 11, 10),
                });

            context.Borrow.AddOrUpdate(b => b.BorrowID,
                new Borrow
                {
                    BorrowID = 1,
                    BookID = 1,
                    UserID = 1,
                    FromDate = new DateTime(2002, 12, 12),
                    ToDate = new DateTime(2003, 1, 12),
                    IsReturned = false
                },
                new Borrow
                {
                    BorrowID = 2,
                    BookID = 4,
                    UserID = 1,
                    FromDate = new DateTime(2003, 1, 12),
                    ToDate = new DateTime(2003, 2, 12),
                    IsReturned = false
                },
                new Borrow
                {
                    BorrowID = 3,
                    BookID = 5,
                    UserID = 2,
                    FromDate = new DateTime(2000, 10, 11),
                    ToDate = new DateTime(2000, 12, 20),
                    IsReturned = false
                });
        }
    }
}
