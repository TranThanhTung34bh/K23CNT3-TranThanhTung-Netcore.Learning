using Microsoft.AspNetCore.Mvc;
using Ttt_lab04.Models;
using System.Linq;

namespace Ttt_lab04.Controllers
{
    public class TttBookController : Controller
    {
        private List<TttBook> tttBooks = new List<TttBook>
{
    new TttBook
    {
        TttId = "1",
        TttTitle = "Lập trình C# cơ bản",
        TttDescription = "Hướng dẫn chi tiết lập trình C# từ cơ bản đến nâng cao.",
        TttImage = "https://images-na.ssl-images-amazon.com/images/I/41-sN-mzwKL._SX379_BO1,204,203,200_.jpg",
        TttPrice = "500000",
        TttPage = "464",
    },
    new TttBook
    {
        TttId = "2",
        TttTitle = "ASP.NET Core thực chiến",
        TttDescription = "Xây dựng ứng dụng web hiện đại với ASP.NET Core.",
        TttImage = "https://m.media-amazon.com/images/I/41tc-LYF0oL._SX379_BO1,204,203,200_.jpg",
        TttPrice = "450000",
        TttPage = "352",
    },
    new TttBook
    {
        TttId = "3",
        TttTitle = "Cấu trúc dữ liệu & Giải thuật",
        TttDescription = "Cẩm nang học cấu trúc dữ liệu và giải thuật bằng C#.",
        TttImage = "https://m.media-amazon.com/images/I/61vI+vZwhlL._SX379_BO1,204,203,200_.jpg",
        TttPrice = "650000",
        TttPage = "1312",
    },
    new TttBook
    {
        TttId = "4",
        TttTitle = "Thực hành Entity Framework Core",
        TttDescription = "Hướng dẫn sử dụng EF Core trong các ứng dụng thực tế.",
        TttImage = "https://m.media-amazon.com/images/I/51k+eUqHjIL._SX379_BO1,204,203,200_.jpg",
        TttPrice = "520000",
        TttPage = "395",
    },
    new TttBook
    {
        TttId = "5",
        TttTitle = "Refactoring",
        TttDescription = "Tạo API mạnh mẽ và bảo mật với .NET và JWT.",
        TttImage = "https://m.media-amazon.com/images/I/41jEbK-jG+L._SX379_BO1,204,203,200_.jpg",
        TttPrice = "480000",
        TttPage = "448",
    }
};


        // Danh sách sách
        public IActionResult TttIndex()
        {
            return View(tttBooks);
        }

        // Hiển thị form tạo mới
        public IActionResult TttCreate()
        {
            return View();
        }

        // Nhận dữ liệu và thêm sách mới
        [HttpPost]
        public IActionResult TttCreate(TttBook tttBook)
        {
            tttBooks.Add(tttBook);
            return RedirectToAction("TttIndex");
        }

        // Hiển thị form sửa sách
        public IActionResult TttEdit(string id)
        {
            var book = tttBooks.FirstOrDefault(b => b.TttId == id);
            if (book == null) return NotFound();
            return View(book);
        }

        // Nhận dữ liệu và cập nhật sách
        [HttpPost]
        public IActionResult TttEdit(TttBook tttBook)
        {
            var existing = tttBooks.FirstOrDefault(b => b.TttId == tttBook.TttId);
            if (existing == null) return NotFound();

            existing.TttTitle = tttBook.TttTitle;
            existing.TttDescription = tttBook.TttDescription;
            existing.TttImage = tttBook.TttImage;
            existing.TttPrice = tttBook.TttPrice;
            existing.TttPage = tttBook.TttPage;

            return RedirectToAction("TttIndex");
        }

        // Hiển thị xác nhận xóa
        public IActionResult TttDelete(string id)
        {
            var book = tttBooks.FirstOrDefault(b => b.TttId == id);
            if (book == null) return NotFound();
            return View(book);
        }

        // Thực hiện xóa
        [HttpPost, ActionName("TttDelete")]
        public IActionResult TttDeleteConfirmed(string id)
        {
            var book = tttBooks.FirstOrDefault(b => b.TttId == id);
            if (book != null)
            {
                tttBooks.Remove(book);
            }
            return RedirectToAction("TttIndex");
        }

        // Xem chi tiết sách
        public IActionResult TttDetails(string id)
        {
            var book = tttBooks.FirstOrDefault(b => b.TttId == id);
            if (book == null) return NotFound();
            return View(book);
        }
    }
}
