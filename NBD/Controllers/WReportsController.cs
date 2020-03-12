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
    public class WReportsController : Controller
    {
        private readonly NBDContext _context;

        public WReportsController(NBDContext context)
        {
            _context = context;
        }

        // GET: WReports
        public async Task<IActionResult> Index()
        {
            var nBDContext = _context.WReports.Include(w => w.Employee).Include(w => w.Project).Include(w => w.Task);
            return View(await nBDContext.ToListAsync());
        }

        // GET: WReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wReport = await _context.WReports
                .Include(w => w.Employee)
                .Include(w => w.Project)
                .Include(w => w.Task)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (wReport == null)
            {
                return NotFound();
            }

            return View(wReport);
        }

        // GET: WReports/Create
        public IActionResult Create()
        {
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "FullName");
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name");
            ViewData["TaskID"] = new SelectList(_context.Tasks, "ID", "Description");
            return View();
        }

        // POST: WReports/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,date,Hour,Cost,EmployeeID,TaskID,ProjectID")] WReport wReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "FullName", wReport.EmployeeID);
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name", wReport.ProjectID);
            ViewData["TaskID"] = new SelectList(_context.Tasks, "ID", "Description", wReport.TaskID);
            return View(wReport);
        }

        // GET: WReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wReport = await _context.WReports.FindAsync(id);
            if (wReport == null)
            {
                return NotFound();
            }
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "FullName", wReport.EmployeeID);
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name", wReport.ProjectID);
            ViewData["TaskID"] = new SelectList(_context.Tasks, "ID", "Description", wReport.TaskID);
            return View(wReport);
        }

        // POST: WReports/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,date,Hour,Cost,EmployeeID,TaskID,ProjectID")] WReport wReport)
        {
            if (id != wReport.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WReportExists(wReport.ID))
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
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "FullName", wReport.EmployeeID);
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name", wReport.ProjectID);
            ViewData["TaskID"] = new SelectList(_context.Tasks, "ID", "Description", wReport.TaskID);
            return View(wReport);
        }

        // GET: WReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wReport = await _context.WReports
                .Include(w => w.Employee)
                .Include(w => w.Project)
                .Include(w => w.Task)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (wReport == null)
            {
                return NotFound();
            }

            return View(wReport);
        }

        // POST: WReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wReport = await _context.WReports.FindAsync(id);
            _context.WReports.Remove(wReport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WReportExists(int id)
        {
            return _context.WReports.Any(e => e.ID == id);
        }
    }
}
