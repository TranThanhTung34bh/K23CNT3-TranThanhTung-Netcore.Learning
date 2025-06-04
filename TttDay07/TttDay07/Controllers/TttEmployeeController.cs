using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TttDay07.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TttDay07.Controllers
{
    public class TttEmployeeController : Controller
    {
        public static List<TttEmployee> tttLEmployee = new List<TttEmployee>
        {
            new TttEmployee
            {
                TttEmployeeId = 115,
                TtttName = "Trần Thanh Tùng",
                TttEmail = "tung@example.com",
                TttBirtday = new DateTime(2005, 5, 30),
                TttSalary = 15000000,
                TttDepartment = "IT"
            },
            new TttEmployee
            {
                TttEmployeeId = 2,
                TtttName = "Tran Thi B",
                TttEmail = "b.tran@example.com",
                TttBirtday = new DateTime(1992, 8, 20),
                TttSalary = 13000000,
                TttDepartment = "HR"
            },
            new TttEmployee
            {
                TttEmployeeId = 3,
                TtttName = "Le Van C",
                TttEmail = "c.le@example.com",
                TttBirtday = new DateTime(1988, 12, 1),
                TttSalary = 18000000,
                TttDepartment = "Finance"
            },
            new TttEmployee
            {
                TttEmployeeId = 4,
                TtttName = "Pham Thi D",
                TttEmail = "d.pham@example.com",
                TttBirtday = new DateTime(1995, 3, 15),
                TttSalary = 12000000,
                TttDepartment = "Marketing"
            },
            new TttEmployee
            {
                TttEmployeeId = 5,
                TtttName = "Hoang Van E",
                TttEmail = "e.hoang@example.com",
                TttBirtday = new DateTime(1993, 7, 7),
                TttSalary = 16000000,
                TttDepartment = "IT"
            }
        };

        // GET: TttEmployeeController
        public IActionResult TttIndex()
        {
            return View(tttLEmployee);
        }

        // GET: TttEmployeeController/Details/5
        public ActionResult TttDetails(int id)
        {
            var employee = tttLEmployee.FirstOrDefault(e => e.TttEmployeeId == id);
            if (employee == null) return NotFound();
            return View(employee);
        }

        // GET: TttEmployeeController/Create
        public ActionResult TttCreate()
        {
            return View();
        }

        // POST: TttEmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TttCreate(TttEmployee tttModels)
        {
            try
            {
                tttModels.TttEmployeeId = tttLEmployee.Max(x => x.TttEmployeeId) + 1;
                tttLEmployee.Add(tttModels);
                return RedirectToAction(nameof(TttIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: TttEmployeeController/Edit/5
        public ActionResult TttEdit(int id)
        {
            var employee = tttLEmployee.FirstOrDefault(e => e.TttEmployeeId == id);
            if (employee == null) return NotFound();
            return View(employee);
        }

        // POST: TttEmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TttEdit(int id, TttEmployee updatedEmp)
        {
            try
            {
                var employee = tttLEmployee.FirstOrDefault(e => e.TttEmployeeId == id);
                if (employee == null) return NotFound();

                employee.TtttName = updatedEmp.TtttName;
                employee.TttEmail = updatedEmp.TttEmail;
                employee.TttBirtday = updatedEmp.TttBirtday;
                employee.TttSalary = updatedEmp.TttSalary;
                employee.TttDepartment = updatedEmp.TttDepartment;

                return RedirectToAction(nameof(TttIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: TttEmployeeController/Delete/5
        public ActionResult TttDelete(int id)
        {
            var employee = tttLEmployee.FirstOrDefault(e => e.TttEmployeeId == id);
            if (employee == null) return NotFound();
            return View(employee);
        }

        // POST: TttEmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TttDelete(int id, IFormCollection collection)
        {
            try
            {
                var employee = tttLEmployee.FirstOrDefault(e => e.TttEmployeeId == id);
                if (employee != null)
                {
                    tttLEmployee.Remove(employee);
                }
                return RedirectToAction(nameof(TttIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}
