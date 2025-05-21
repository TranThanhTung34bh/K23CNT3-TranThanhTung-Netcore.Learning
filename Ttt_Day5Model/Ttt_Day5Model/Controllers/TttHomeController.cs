using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ttt_Day5Model.Models;
using Ttt_Day5Model.Models.DataModels;

namespace Ttt_Day5Model.Controllers
{
    public class TttHomeController : Controller
    {
        private readonly ILogger<TttHomeController> _logger;

        public TttHomeController(ILogger<TttHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult TttIndex()
        {
            return View();
        }
        public IActionResult TttAbout()
        {
            var Tttmember = new TttMember(); // Ensure TttMember is defined in the Ttt_Day5Model.Models namespace
            Tttmember.TttMemberId = Guid.NewGuid().ToString();
            Tttmember.TttUserName = "Tùng";
            Tttmember.TttFullName = "Trần Thanh Tùng";
            Tttmember.TttPassword = "123456";
            Tttmember.TttEmail = "tung@gmail.com";
            return View(Tttmember);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
