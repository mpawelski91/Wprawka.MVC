using Library.Data.DAL;
using Library.Data.Entities;
using Library.Service.Interfaces;
using Library.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public class UnitOfWork : IDisposable
    {
        protected LibraryContext dbContext = new LibraryContext();

        #region Repositories

        private Repository<User> _userRepository;

        public IRepository<User> UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new Repository<User>(dbContext);
                }

                return _userRepository;
            }
        }

        private Repository<Book> _bookRepository;

        public IRepository<Book> BookRepository
        {
            get
            {
                if (_bookRepository == null)
                {
                    _bookRepository = new Repository<Book>(dbContext);
                }

                return _bookRepository;
            }
        }

        private Repository<DictBookGenre> _dictBookGenreRepository;

        public IRepository<DictBookGenre> DictBookGenreRepository
        {
            get
            {
                if (_dictBookGenreRepository == null)
                {
                    _dictBookGenreRepository = new Repository<DictBookGenre>(dbContext);
                }

                return _dictBookGenreRepository;
            }
        }

        private Repository<Borrow> _borrowRepository;

        public IRepository<Borrow> BorrowRepository
        {
            get
            {
                if (_borrowRepository == null)
                {
                    _borrowRepository = new Repository<Borrow>(dbContext);
                }

                return _borrowRepository;
            }
        }

        #endregion Repositories

        public void Commit()
        {
            dbContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
