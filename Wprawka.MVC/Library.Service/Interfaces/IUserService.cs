using Library.Common.ViewModels.User;
using Library.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service.Interfaces
{
    public interface IUserService : IDisposable
    {
        IEnumerable<UserListViewModel> GetAll();

        UserDTO GetByID(int id);

        void Edit(EditUserViewModel user);

        void Delete(int id);

        void Add(CreateUserViewModel user);
    }
}
