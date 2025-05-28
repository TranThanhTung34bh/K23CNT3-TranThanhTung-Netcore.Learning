using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TttLab06.Models;

namespace TttLab06.Controllers
{
    public class TttEmployeeController : Controller
    {
        // Danh sách nhân viên
        public static List<TttEmployee> TttListEmployee = new List<TttEmployee>
        {
            new TttEmployee 
            { TttId = 115,
                TttName = "Trần Thanh Tùng",
                TttBirthDay = new DateTime(2005,5,30),
                TttEmail = "a@mail.com", TttPhone = "0901123456",
                TttSalary = 5000,
                TttStatus = true 
            },
            new TttEmployee 
            { 
                TttId = 2,
                TttName = "Trần Thị B",
                TttBirthDay = new DateTime(2005,5,20),
                TttEmail = "b@mail.com",
                TttPhone = "0902123456",
                TttSalary = 6000,
                TttStatus = false 
            },
            new TttEmployee 
            { 
                TttId = 3,
                TttName = "Lê Văn C",
                TttBirthDay = new DateTime( 2005, 3, 19),
                TttEmail = "c@mail.com",
                TttPhone = "0903234567",
                TttSalary = 4500, TttStatus = true
            },
            new TttEmployee 
            { 
                TttId = 4,
                TttName = "Phạm Văn D",
                TttBirthDay = new DateTime( 2004, 4,20),
                TttEmail = "d@mail.com",
                TttPhone = "0904567890",
                TttSalary = 7000,
                TttStatus = false
            },
            new TttEmployee 
            { 
                TttId = 5,
                TttName = "Sinh viên TTT",
                TttBirthDay = new DateTime(2003, 5, 5),
                TttEmail = "sv.ttt@mail.com",
                TttPhone = "0912345678",
                TttSalary = 0,
                TttStatus = true 
            }
        };

        public IActionResult TttIndex()
        {
            return View(TttListEmployee);
        }

        [HttpGet]
        public IActionResult TttCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TttCreateSubmit(TttEmployee emp)
        {
            emp.TttId = TttListEmployee.Max(e => e.TttId) + 1;
            TttListEmployee.Add(emp);
            return RedirectToAction("TttIndex");
        }

        [HttpGet]
        public IActionResult TttEdit(int id)
        {
            var emp = TttListEmployee.FirstOrDefault(e => e.TttId == id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult TttEditPUT(TttEmployee updatedEmp)
        {
            var emp = TttListEmployee.FirstOrDefault(e => e.TttId == updatedEmp.TttId);
            if (emp != null)
            {
                emp.TttName = updatedEmp.TttName;
                emp.TttBirthDay = updatedEmp.TttBirthDay;
                emp.TttEmail = updatedEmp.TttEmail;
                emp.TttPhone = updatedEmp.TttPhone;
                emp.TttSalary = updatedEmp.TttSalary;
                emp.TttStatus = updatedEmp.TttStatus;
            }
            return RedirectToAction("TttIndex");
        }

        public IActionResult TttDelete(int id)
        {
            var emp = TttListEmployee.FirstOrDefault(e => e.TttId == id);
            if (emp != null) TttListEmployee.Remove(emp);
            return RedirectToAction("TttIndex");
        }
    }
}
