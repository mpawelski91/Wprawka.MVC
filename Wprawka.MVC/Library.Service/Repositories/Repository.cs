using Library.Data.DAL;
using Library.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected LibraryContext dbContext;

        protected DbSet<T> dbSet;

        public IEnumerable<T> DataSet { get { return dbSet; } }

        public Repository(LibraryContext context)
        {
            dbContext = context;
            dbSet = context.Set<T>();
        }

        public void Create(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return dbSet;
        }

        public T GetByID(int id)
        {
            return dbSet.Find(id);
        }

        public void Update(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        private void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
            }
        }

        private bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
