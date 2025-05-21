using Microsoft.AspNetCore.Mvc;
using Ttt_Day5Model.Models.DataModels;

namespace TttLesson05.Controllers
{
    public class TttMemberController : Controller
    {
        private static List<TttMember> TttListMember = new List<TttMember>()
        {
            new TttMember
    {
        TttMemberId = "2310900115",
        TttUserName = "Tung",
        TttPassword = "pass1234",
        TttFullName = "Tran Thanh Tung",
        TttEmail = "tung@gmail.com"
    },
    new TttMember
    {
        TttMemberId = "M002",
        TttUserName = "jane456",
        TttPassword = "pass2",
        TttFullName = "Jane Smith",
        TttEmail = "jane@example.com"
    },
    new TttMember
    {
        TttMemberId = "M003",
        TttUserName = "david789",
        TttPassword = "pass3",
        TttFullName = "David Johnson",
        TttEmail = "david@example.com"
    },
    new TttMember
    {
        TttMemberId = "M004",
        TttUserName = "alice321",
        TttPassword = "pass4",
        TttFullName = "Alice Brown",
        TttEmail = "alice@example.com"
    },
    new TttMember
    {
        TttMemberId = "M005",
        TttUserName = "bob999",
        TttPassword = "pass5",
        TttFullName = "Bob White",
        TttEmail = "bob@example.com"
    }
        };

        public string TttMemberId { get; internal set; }
        public string TttUserName { get; internal set; }
        public string TttPassword { get; internal set; }
        public string TttFullName { get; internal set; }
        public string TttEmail { get; internal set; }

        public IActionResult TttIndex()
        {
            return View(TttListMember);
        }
    }
}
