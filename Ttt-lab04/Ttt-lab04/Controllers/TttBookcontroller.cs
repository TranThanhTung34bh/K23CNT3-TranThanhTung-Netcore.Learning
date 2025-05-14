using Microsoft.AspNetCore.Mvc;
using Ttt_lab04.Models;

namespace Ttt_lab04.Controllers
{
    public class TttBookcontroller : Controller
    {

        private List<TttBook> tttBooks = new List<TttBook>
{
    new TttBook
    {
        TttId = "1",
        TttTitle = "Lập trình C# cơ bản",
        TttDescription = "Hướng dẫn chi tiết lập trình C# từ cơ bản đến nâng cao.",
        TttImage = "book1.jpg",
        TttPrice = "500000", // Changed from float to string
        TttPage = "464", // Fixed: Changed from int to string
    },
    new TttBook
    {
        TttId = "2",
        TttTitle = "ASP.NET Core thực chiến",
        TttDescription = "Xây dựng ứng dụng web hiện đại với ASP.NET Core.",
        TttImage = "book2.jpg",
        TttPrice = "450000", // Changed from float to string
        TttPage = "352", // Fixed: Changed from int to string
    },
    new TttBook
    {
        TttId = "3",
        TttTitle = "Cấu trúc dữ liệu & Giải thuật",
        TttDescription = "Cẩm nang học cấu trúc dữ liệu và giải thuật bằng C#.",
        TttImage = "algo.jpg",
        TttPrice = "650000", // Changed from float to string
        TttPage = "1312", // Fixed: Changed from int to string
    },
    new TttBook
    {
        TttId = "4",
        TttTitle = "Thực hành Entity Framework Core",
        TttDescription = "Hướng dẫn sử dụng EF Core trong các ứng dụng thực tế.",
        TttImage = "https://m.media-amazon.com/images/I/51k+eUqHjIL._SX258_BO1,204,203,200_.jpg",
        TttPrice = "520000", // Changed from float to string
        TttPage = "395", // Fixed: Changed from int to string
    },
    new TttBook
    {
        TttId = "5",
        TttTitle = "Refactoring",
        TttDescription = "Tạo API mạnh mẽ và bảo mật với .NET và JWT.",
        TttImage = "https://m.media-amazon.com/images/I/41jEbK-jG+L._SX396_BO1,204,203,200_.jpg",
        TttPrice = "480000", // Changed from float to string
        TttPage = "448", // Fixed: Changed from int to string
    }
};

        public IActionResult TttIndex()
        {
            return View(tttBooks); // Fixed typo: Changed "Ttt" to "tttBooks"
        }
    }
}