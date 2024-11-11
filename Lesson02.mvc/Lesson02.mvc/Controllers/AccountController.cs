using Lesson02.mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson02.mvc.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> accounts = new List<Account>
            {
                new Account()
                {
                    Id = 1,
                    Name = "Test",
                    Email = "Test@gmail.com",
                    Phone="0987654321",
                    Address="Hà Nội",
                    Avatar=Url.Content("~/images/Avatar/1.jpg"),
                    Gender=1,
                    Bio="Handsome",
                    Birthday = new DateTime(2003,9,2)
                },
                new Account()
                {
                    Id = 2,
                    Name = "Test",
                    Email = "Test@gmail.com",
                    Phone="0987654321",
                    Address="Hà Nội",
                    Avatar=Url.Content("~/images/Avatar/1.jpg"),
                    Gender=1,
                    Bio="Handsome",
                    Birthday = new DateTime(2003,9,2)
                },
                new Account()
                {
                    Id = 3,
                    Name = "Test",
                    Email = "Test@gmail.com",
                    Phone="0987654321",
                    Address="Hà Nội",
                    Avatar=Url.Content("~/images/Avatar/1.jpg"),
                    Gender=1,
                    Bio="Handsome",
                    Birthday = new DateTime(2003,9,2)
                }

            };
            ViewBag.Accounts = accounts;
            return View();
        }
        public IActionResult Profile()
        {
            Account account = new Account()
            {
                Id = 1,
                Name = "Dân",
                Email = "damquocdan@gmail.com",
                Phone = "0987654321",
                Address = "Hà Nội",
                Avatar = Url.Content("~/images/Avatar/1.jpg"),
                Gender = 1,
                Bio = "deptrai",
                Birthday = new DateTime(2003 / 9 / 2)
            };
            ViewBag.account = account;
            return View();
        }
    }
}
