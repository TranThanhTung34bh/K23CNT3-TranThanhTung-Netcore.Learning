using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TttDay9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TttDay9.Controllers
{
    public class TttCategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
