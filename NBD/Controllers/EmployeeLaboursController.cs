using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NBD.Data;
using NBD.Models;

namespace NBD.Controllers
{
    public class EmployeeLaboursController : Controller
    {
        private readonly NBDContext _context;

        public EmployeeLaboursController(NBDContext context)
        {
            _context = context;
        }

        // GET: EmployeeLabours
        public async Task<IActionResult> Index()
        {
            var nBDContext = _context.EmployeeLabours.Include(e => e.Employee).Include(e => e.Project);
            return View(await nBDContext.ToListAsync());
        }

        // GET: EmployeeLabours/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeLabour = await _context.EmployeeLabours
                .Include(e => e.Employee)
                .Include(e => e.Project)
                .FirstOrDefaultAsync(m => m.ProjectID == id);
            if (employeeLabour == null)
            {
                return NotFound();
            }

            return View(employeeLabour);
        }

        // GET: EmployeeLabours/Create
        public IActionResult Create()
        {
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "Email");
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name");
            return View();
        }

        // POST: EmployeeLabours/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,EmployeeReport,ProjectID,EmployeeID,Hour,Cost")] EmployeeLabour employeeLabour)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeLabour);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "Email", employeeLabour.EmployeeID);
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name", employeeLabour.ProjectID);
            return View(employeeLabour);
        }

        // GET: EmployeeLabours/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeLabour = await _context.EmployeeLabours.FindAsync(id);
            if (employeeLabour == null)
            {
                return NotFound();
            }
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "Email", employeeLabour.EmployeeID);
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name", employeeLabour.ProjectID);
            return View(employeeLabour);
        }

        // POST: EmployeeLabours/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,EmployeeReport,ProjectID,EmployeeID,Hour,Cost")] EmployeeLabour employeeLabour)
        {
            if (id != employeeLabour.ProjectID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeLabour);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeLabourExists(employeeLabour.ProjectID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "Email", employeeLabour.EmployeeID);
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name", employeeLabour.ProjectID);
            return View(employeeLabour);
        }

        // GET: EmployeeLabours/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeeLabour = await _context.EmployeeLabours
                .Include(e => e.Employee)
                .Include(e => e.Project)
                .FirstOrDefaultAsync(m => m.ProjectID == id);
            if (employeeLabour == null)
            {
                return NotFound();
            }

            return View(employeeLabour);
        }

        // POST: EmployeeLabours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employeeLabour = await _context.EmployeeLabours.FindAsync(id);
            _context.EmployeeLabours.Remove(employeeLabour);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeLabourExists(int id)
        {
            return _context.EmployeeLabours.Any(e => e.ProjectID == id);
        }
    }
}
