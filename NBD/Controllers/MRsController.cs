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
    public class MRsController : Controller
    {
        private readonly NBDContext _context;

        public MRsController(NBDContext context)
        {
            _context = context;
        }

        // GET: MRs
        public async Task<IActionResult> Index()
        {
            var nBDContext = _context.MRs.Include(m => m.Employee).Include(m => m.Material).Include(m => m.Project);
            return View(await nBDContext.ToListAsync());
        }

        // GET: MRs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mR = await _context.MRs
                .Include(m => m.Employee)
                .Include(m => m.Material)
                .Include(m => m.Project)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (mR == null)
            {
                return NotFound();
            }

            return View(mR);
        }

        // GET: MRs/Create
        public IActionResult Create()
        {
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "FullName");
            ViewData["MaterialID"] = new SelectList(_context.Materials, "ID", "Description");
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name");
            return View();
        }

        // POST: MRs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,date,Qnty,Cost,MaterialID,EmployeeID,ProjectID")] MR mR)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mR);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "FullName", mR.EmployeeID);
            ViewData["MaterialID"] = new SelectList(_context.Materials, "ID", "Description", mR.MaterialID);
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name", mR.ProjectID);
            return View(mR);
        }

        // GET: MRs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mR = await _context.MRs.FindAsync(id);
            if (mR == null)
            {
                return NotFound();
            }
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "FullName", mR.EmployeeID);
            ViewData["MaterialID"] = new SelectList(_context.Materials, "ID", "Description", mR.MaterialID);
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name", mR.ProjectID);
            return View(mR);
        }

        // POST: MRs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,date,Qnty,Cost,MaterialID,EmployeeID,ProjectID")] MR mR)
        {
            if (id != mR.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mR);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MRExists(mR.ID))
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
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "FullName", mR.EmployeeID);
            ViewData["MaterialID"] = new SelectList(_context.Materials, "ID", "Description", mR.MaterialID);
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name", mR.ProjectID);
            return View(mR);
        }

        // GET: MRs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mR = await _context.MRs
                .Include(m => m.Employee)
                .Include(m => m.Material)
                .Include(m => m.Project)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (mR == null)
            {
                return NotFound();
            }

            return View(mR);
        }

        // POST: MRs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mR = await _context.MRs.FindAsync(id);
            _context.MRs.Remove(mR);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MRExists(int id)
        {
            return _context.MRs.Any(e => e.ID == id);
        }
    }
}
