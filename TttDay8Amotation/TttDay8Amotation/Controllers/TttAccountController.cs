using Microsoft.AspNetCore.Mvc;
using TttDay8Amotation.Models;
namespace TttDay8Amotation.Controllers
{
    public class TttAccountController : Controller
    {
        private static List<TttAccount> tttListAccount = new List<TttAccount>()
        {
            new TttAccount
            {
                TttId = 115,
                TttFullName = "Trần Thanh Tùng",
                TttEmail = "tungtt2005@gmail.com",
                TttPhone = "0912345678",
                TttAddress = "123 Đường Láng, Đống Đa, Hà Nội",
                TttAvatar = "https://i.pravatar.cc/150?img",
                TttGender = "Nam",
                TttPassword = "MatKhau123",
                TttFacebook = "https://facebook.com/tung34bh",
                TttBirthday = new DateTime(2005, 5, 30)
            },
            new TttAccount
            {
                TttId = 2,
                TttFullName = "Trần Thị B",
                TttEmail = "tranthib@example.com",
                TttPhone = "0987654321",
                TttAddress = "456 Trường Chinh, Thanh Xuân, Hà Nội",
                TttAvatar = "https://i.pravatar.cc/150?img",
                TttGender = "Nữ",
                TttPassword = "12345678",
                TttFacebook = "https://facebook.com/tranthib",
                TttBirthday = new DateTime(1999, 12, 1)
            },
            new TttAccount
            {
                TttId = 3,
                TttFullName = "Phạm Văn C",
                TttEmail = "phamvanc@example.com",
                TttPhone = "0938123456",
                TttAddress = "789 Nguyễn Trãi, Hà Đông, Hà Nội",
                TttAvatar = "https://i.pravatar.cc/150?img",
                TttGender = "Nam",
                TttPassword = "abc@1234",
                TttFacebook = "https://facebook.com/phamvanc",
                TttBirthday = new DateTime(2001, 8, 21)
            },
            new TttAccount
            {
                TttId = 4,
                TttFullName = "Lê Thị D",
                TttEmail = "lethid@example.com",
                TttPhone = "0971234567",
                TttAddress = "11 Lê Lợi, TP. Huế",
                TttAvatar = "https://tse3.mm.bing.net/th/id/OIP.nQNKsoYYdg3ZGWHSFac5BwHaIE?r=0&pid=ImgDet&w=184&h=200&c=7&dpr=1.3",
                TttGender = "Nữ",
                TttPassword = "Matkhau456",
                TttFacebook = "https://facebook.com/lethid",
                TttBirthday = new DateTime(2002, 3, 10)
            },
            new TttAccount
            {
                TttId = 5,
                TttFullName = "Đặng Minh E",
                TttEmail = "dangminhe@example.com",
                TttPhone = "0909988776",
                TttAddress = "20 Pasteur, Quận 1, TP.HCM",
                TttAvatar = "https://numpaint.com/wp-content/uploads/2020/08/One-Piece-Luffy-510x639.jpg",
                TttGender = "Nam",
                TttPassword = "DangMinh!2024",
                TttFacebook = "https://facebook.com/dangminhe",
                TttBirthday = new DateTime(1998, 7, 30)
            }
        };

        // GET: TttAccountController
        public ActionResult TttIndex()
        {
            return View(tttListAccount);
        }

        // GET: TttAccountController/Details/5
        public ActionResult TttDetails(int id)
        {
            return View();
        }

        // GET: TttAccountController/Create
        public ActionResult TttCreate()
        {
            return View();
        }

        // POST: TttAccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TttCreate(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(TttIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: TttAccountController/Edit/5
        public ActionResult TttEdit(int id)
        {
            return View();
        }

        // POST: TttAccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TttEdit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(TttIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: TttAccountController/Delete/5
        public ActionResult TttDelete(int id)
        {
            return View();
        }

        // POST: TttAccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TttDelete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(TttIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}
