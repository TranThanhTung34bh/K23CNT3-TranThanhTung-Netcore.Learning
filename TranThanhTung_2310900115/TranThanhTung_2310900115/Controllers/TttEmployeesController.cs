using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TranThanhTung_2310900115.Models;

namespace TranThanhTung_2310900115.Controllers
{
    public class TttEmployeesController : Controller
    {
        private readonly TranThanhTung2310900115Context _context;

        public TttEmployeesController(TranThanhTung2310900115Context context)
        {
            _context = context;
        }

        // GET: TttEmployees
        public async Task<IActionResult> TttIndex()
        {
            return View(await _context.TttEmployees.ToListAsync());
        }

        // GET: TttEmployees/TttDetails/5
        public async Task<IActionResult> TttDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tttEmployee = await _context.TttEmployees
                .FirstOrDefaultAsync(m => m.TttEmpId == id);
            if (tttEmployee == null)
            {
                return NotFound();
            }

            return View(tttEmployee);
        }

        // GET: TttEmployees/TttCreate
        public IActionResult TttCreate()
        {
            return View();
        }

        // POST: TttEmployees/TttCreate
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more TttDetails, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TttCreate([Bind("TttEmpId,TttEmpName,TttEmpLevel,TttEmpStartDate,TttEmpStatus")] TttEmployee tttEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tttEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(TttIndex));
            }
            return View(tttEmployee);
        }

        // GET: TttEmployees/TttEdit/5
        public async Task<IActionResult> TttEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tttEmployee = await _context.TttEmployees.FindAsync(id);
            if (tttEmployee == null)
            {
                return NotFound();
            }
            return View(tttEmployee);
        }

        // POST: TttEmployees/TttEdit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more TttDetails, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TttEdit(int id, [Bind("TttEmpId,TttEmpName,TttEmpLevel,TttEmpStartDate,TttEmpStatus")] TttEmployee tttEmployee)
        {
            if (id != tttEmployee.TttEmpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tttEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TttEmployeeExists(tttEmployee.TttEmpId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(TttIndex));
            }
            return View(tttEmployee);
        }

        // GET: TttEmployees/TttDelete/5
        public async Task<IActionResult> TttDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tttEmployee = await _context.TttEmployees
                .FirstOrDefaultAsync(m => m.TttEmpId == id);
            if (tttEmployee == null)
            {
                return NotFound();
            }

            return View(tttEmployee);
        }

        // POST: TttEmployees/TttDelete/5
        [HttpPost, ActionName("TttDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> TttDeleteConfirmed(int id)
        {
            var tttEmployee = await _context.TttEmployees.FindAsync(id);
            if (tttEmployee != null)
            {
                _context.TttEmployees.Remove(tttEmployee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(TttIndex));
        }

        private bool TttEmployeeExists(int id)
        {
            return _context.TttEmployees.Any(e => e.TttEmpId == id);
        }
    }
}
