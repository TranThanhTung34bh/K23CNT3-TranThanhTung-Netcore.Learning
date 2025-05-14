using System.Security.Principal;
using Microsoft.AspNetCore.Mvc;
using TttLap03.Models;

namespace TttLap03.Controllers
{
    public class TttAccountController : Controller
    {
        public IActionResult Index()
        {
            var accounts = new List<Account>
            {
                new Account { FullName = "Hoàng Anh", Bio = "My name is small", Image = "img1.jpg" },
                new Account { FullName = "Trường Giang", Bio = "My name is small", Image = "img2.jpg" },
                new Account { FullName = "Hoàng Thúy", Bio = "My name is small", Image = "img3.jpg" },
            };

            return View(accounts);
        }

        public IActionResult Profile()
        {
            var account = new Account
            {
                FullName = "Hoàng Anh",
                Email = "anh@gmail.com",
                Phone = "0986456789",
                Address = "Hà Nội",
                Gender = "Male",
                Birthday = new DateTime(1998, 7, 15),
                Bio = "My name is small",
                Image = "img1.jpg"
            };

            return View(account);
        }
    }
}
