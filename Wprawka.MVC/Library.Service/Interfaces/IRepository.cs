using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> DataSet { get; }

        T GetByID(int id);

        IQueryable<T> GetAll();

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
