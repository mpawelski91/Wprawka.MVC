using Library.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Service.DTO;
using Library.Common.Helpers;
using Library.Data.Entities;
using Library.Common.ViewModels.User;

namespace Library.Service.Repositories
{
    public class UserService : IUserService
    {
        public void Add(CreateUserViewModel user)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var newUser = new User();
                user.CopyProperties(newUser);
                newUser.AddDate = DateTime.Now;
                newUser.ModifiedDate = null;
                newUser.IsActive = true;

                unitOfWork.UserRepository.Create(newUser);
                unitOfWork.Commit();
            }
        }

        public void Delete(int id)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var user = unitOfWork.UserRepository.GetByID(id);
                user.IsActive = false;
                user.ModifiedDate = DateTime.Now;

                unitOfWork.UserRepository.Update(user);
                unitOfWork.Commit();
            }
        }

        public void Edit(EditUserViewModel user)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var editedUser = unitOfWork.UserRepository.GetByID(user.UserID);
                user.CopyProperties(editedUser);
                editedUser.ModifiedDate = DateTime.Now;

                unitOfWork.UserRepository.Update(editedUser);
                unitOfWork.Commit();
            }
        }

        public IEnumerable<UserListViewModel> GetAll()
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var users = new List<UserListViewModel>();

                foreach(var user in unitOfWork.UserRepository.GetAll())
                {
                    var userVM = new UserListViewModel();
                    user.CopyProperties(userVM);
                    userVM.UserName = user.FirstName + " " + user.LastName;
                    userVM.BooksBorrowed = unitOfWork.BorrowRepository.GetAll().Where(x => x.UserID == user.UserID).Count();
                    users.Add(userVM);
                }

                return users;
            }
        }

        public UserDTO GetByID(int id)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var user = unitOfWork.UserRepository.GetByID(id);
                var userDTO = new UserDTO();
                user.CopyProperties(userDTO);
                userDTO.BooksBorrowed = unitOfWork.BorrowRepository.GetAll().Where(x => x.UserID == user.UserID).Count();

                return userDTO;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
