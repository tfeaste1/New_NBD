﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using NBD.Data;
using NBD.Models;
using NBD.ViewModels;

namespace NBD.Controllers
{
    public class TeamsController : Controller
    {
        private readonly NBDContext _context;

        public TeamsController(NBDContext context)
        {
            _context = context;
        }

        // GET: Teams
        public async Task<IActionResult> Index()
        {
            var nBDContext = _context.Teams.Include(t => t.Employee).Include(t => t.Project);
            return View(await nBDContext.ToListAsync());
        }

        // GET: Teams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await _context.Teams
                .Include(t => t.Employee)
                .Include(t => t.Project)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        // GET: Teams/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            Team team = new Team();
            PopulateAssignedEmpData(team);
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "FullName");
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name");
            return View();
        }

        // POST: Teams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("ID,Phase,TeamName,EmployeeID,ProjectID")] Team team, string[] selectedOptions)
        {
            try
            {
                //UpdateEmpFullNametoTeam(selectedOptions, team);
                if (ModelState.IsValid)
                {
                    _context.Add(team);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "FullName", team.EmployeeID);
                ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name", team.ProjectID);
            }

            catch (RetryLimitExceededException /* dex */)
            {
                ModelState.AddModelError("", "Unable to save changes after multiple attempts. Try again, and if the problem persists, see your system administrator.");
            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError("", "Something went wrong in the database.");
            }
            PopulateAssignedEmpData(team);
            return View(team);

        }

        // GET: Teams/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await _context.Teams.Include(t => t.Employee)
                 .Include(t => t.Project)
                 .AsNoTracking()
                 .SingleOrDefaultAsync(t => t.ID == id); ;
            if (team == null)
            {
                return NotFound();
            }
            PopulateAssignedEmpData(team);
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "FullName", team.EmployeeID);
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name", team.ProjectID);
            return View(team);
        }

        // POST: Teams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Phase,TeamName,EmployeeID,ProjectID")] Team team, string[] selectedOptions)
        {
            var teamToUpdate = await _context.Teams
           .Include(t => t.Employee)
           .Include(t => t.Project)
           .SingleOrDefaultAsync(d => d.ID == id);
            if (teamToUpdate == null)
            {
                return NotFound();
            }

            //UpdateEmpFullNametoTeam(selectedOptions, teamToUpdate);

            if (await TryUpdateModelAsync<Team>(teamToUpdate, "",
               d => d.Phase, d => d.TeamName, d => d.ProjectID))
            {
                try
                {
                    _context.Update(teamToUpdate);
                    await _context.SaveChangesAsync();
                }
                catch (RetryLimitExceededException /* dex */)
                {
                    ModelState.AddModelError("", "Unable to save changes after multiple attempts. Try again, and if the problem persists, see your system administrator.");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamExists(teamToUpdate.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError("", "Something went wrong in the database.");
                }
                return RedirectToAction(nameof(Index));

            }
            ViewData["EmployeeID"] = new SelectList(_context.Employees, "ID", "FullName", team.EmployeeID);
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name", team.ProjectID);
            PopulateAssignedEmpData(team);
            return View(teamToUpdate);
        }

        // GET: Teams/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await _context.Teams
                .Include(t => t.Employee)
                .Include(t => t.Project)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        // POST: Teams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var team = await _context.Teams.FindAsync(id);
            try
            {
                _context.Teams.Remove(team);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException dex)
            {
                if (dex.InnerException.Message.Contains("FK_Patients_Doctors_DoctorID"))
                {
                    ModelState.AddModelError("", "Unable to save changes. Remember, you cannot delete a Doctor that has Patients.");
                }
                else
                {
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
                }
            }
            return View(team);
        }

        private void PopulateAssignedEmpData(Team team)
        {
            var allEmp = _context.Employees;
            var docSpecialties = new HashSet<int>(team.EmployeeID);
            var selected = new List<OptionVm>();
            var available = new List<OptionVm>();
            foreach (var s in allEmp)
            {
                if (docSpecialties.Contains(s.ID))
                {
                    selected.Add(new OptionVm
                    {
                        ID = s.ID,
                        DisplayText = s.FullName
                    });
                }
                else
                {
                    available.Add(new OptionVm
                    {
                        ID = s.ID,
                        DisplayText = s.FullName
                    });
                }
            }

            ViewData["selOpts"] = new MultiSelectList(selected.OrderBy(s => s.DisplayText), "ID", "DisplayText");
            ViewData["availOpts"] = new MultiSelectList(available.OrderBy(s => s.DisplayText), "ID", "DisplayText");
        }

        //private void UpdateEmpFullNametoTeam(string[] selectedOptions, Team teamToUpdate)
        //{
        //    if (selectedOptions == null)
        //    {
        //        teamToUpdate.employees = new List<Employee>();
        //        return;
        //    }

        //    var selectedOptionsHS = new HashSet<string>(selectedOptions);
        //    var EmpFullName = new HashSet<int>(teamToUpdate.employees.Select(e => e.ID));
        //    foreach (var s in _context.Employees)
        //    {
        //        if (selectedOptionsHS.Contains(s.ID.ToString()))
        //        {
        //            if (!EmpFullName.Contains(s.ID))
        //            {
        //                teamToUpdate.employees.Add(new Employee
        //                {

        //                    ID = teamToUpdate.ID
        //                });
        //            }
        //        }
        //        else
        //        {
        //            if (EmpFullName.Contains(s.ID))
        //            {
        //                Employee specToRemove = teamToUpdate.employees.SingleOrDefault(d => d.ID == s.ID);
        //                _context.Remove(specToRemove);
        //            }
        //        }
        //    }
        //}

        private bool TeamExists(int id)
        {
            return _context.Teams.Any(e => e.ProjectID == id);
        }
    }
}
