using PYS.Web.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PYS.Web.Controllers
{
    public class UserController : Controller
    {        
        public ActionResult Index()
        {
            ViewBag.Title = "Kullanıcı Listesi";


            var users = GenerateUsers();           

            return View(users);
        }

        public ActionResult List()
        {
            ViewBag.Title = "Kullanıcılar";
            var users = GenerateUsers();
            return View(users);
        }


        private static List<UserDto> GenerateUsers()
        {
            var users = new List<UserDto>();
            users.Add(new UserDto() { Name = "Merve", Surname = "Köse", Age = 20, Description = "Bu veriler test amaçlı eklenmiştir." });
            users.Add(new UserDto() { Name = "Merve 2", Surname = "Köse 2", Age = 22, Description = "Bu veriler test amaçlı eklenmiştir. 2" });
            users.Add(new UserDto() { Name = "Merve 3", Surname = "Köse 3", Age = 25, Description = "Bu veriler test amaçlı eklenmiştir. 3" });
            users.Add(new UserDto() { Name = "Merve 4", Surname = "Köse 4", Age = 24, Description = "Bu veriler test amaçlı eklenmiştir. 4" });
            users.Add(new UserDto() { Name = "Merve 5", Surname = "Köse 5", Age = 26, Description = "Bu veriler test amaçlı eklenmiştir. 5 " });
            users.Add(new UserDto() { Name = "Merve 6", Surname = "Köse 6", Age = 26, Description = "Bu veriler test amaçlı eklenmiştir. 6 " });
            return users;
        }
    }
}