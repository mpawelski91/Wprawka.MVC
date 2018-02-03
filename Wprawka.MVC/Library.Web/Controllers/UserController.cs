using Library.Common.Helpers;
using Library.Common.ViewModels.User;
using Library.Service.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        // GET: User
        public ActionResult Index()
        {
            var users = _userService.GetAll();

            return View(users);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(CreateUserViewModel user)
        {
            if (ModelState.IsValid)
            {
                _userService.Add(user);

                return RedirectToAction("Index");
            }

            return View(user);
        }

        public ActionResult Edit(int id)
        {
            var user = _userService.GetByID(id);
            var editUserVM = new EditUserViewModel();
            user.CopyProperties(editUserVM);

            return View(editUserVM);
        }

        [HttpPost]
        public ActionResult Edit(EditUserViewModel user)
        {
            if(ModelState.IsValid)
            {
                _userService.Edit(user);

                return RedirectToAction("Index");
            }

            return View(user);
        }

        public ActionResult Delete(int id)
        {
            _userService.Delete(id);

            return RedirectToAction("Index");
        }

        public ActionResult Back()
        {
            return RedirectToAction("Index");
        }
    }
}