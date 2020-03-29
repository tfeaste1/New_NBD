using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using NBD.Data;
using NBD.Models;
using NBD.ViewModels;

namespace NBD.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly NBDContext _context;

        public ProjectsController(NBDContext context)
        {
            _context = context;
        }

        // GET: Projects
        public async Task<IActionResult> Index()
        {
            var nBDContext = _context.Projects
                .Include(p => p.Client)
                .Include (p=>p.ProjectLabours)
                .ThenInclude(pl => pl.LabourRequirement)
                .Include (p=>p.ProjectMaterials)
                .ThenInclude(pm=>pm.MaterialRequirement);
            return View(await nBDContext.ToListAsync());
        }

        // GET: Projects/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Projects
                .Include(p => p.Client)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // GET: Projects/Create
        public IActionResult Create()
        {
            Project project = new Project();

            PopulateAssignedLaborData(project);
            ViewData["ClientID"] = new SelectList(_context.Clients, "ID", "Address");
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,ProjSite,ProjBidDate,EstStartDate,EstEndDate,StartDate,EndDate,ActAmount,EstAmount,ClientApproval,AdminApproval,ProjCurrentPhase,ClientID,ProjIsFlagged")] Project project, string [] selectedLabors)
        {
            try
            {
                UpdateProjectLabours(selectedLabors, project);
                if (ModelState.IsValid)
                {
                    _context.Add(project);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch(RetryLimitExceededException /* dex */)
                {
                    ModelState.AddModelError("", "Unable to save changes after multiple attempts. Try again, and if the problem persists, see your system administrator.");
                }

            PopulateAssignedLaborData(project);
            ViewData["ClientID"] = new SelectList(_context.Clients, "ID", "Address", project.ClientID);
            return View(project);
        }

        // GET: Projects/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Projects
                .Include(p => p.Client)
                .Include(p => p.ProjectLabours)
                .ThenInclude(p => p.LabourRequirement)
                .ThenInclude(p=>p.Task)
                .Include(p => p.ProjectLabours)
                .ThenInclude(p => p.LabourRequirement)
                .ThenInclude(p => p.Team)
                .AsNoTracking()
                .SingleOrDefaultAsync(p => p.ID == id);
            if (project == null)
            {
                return NotFound();
            }

            PopulateAssignedLaborData(project);
            ViewData["ClientID"] = new SelectList(_context.Clients, "ID", "Address", project.ClientID);
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,ProjSite,ProjBidDate,EstStartDate,EstEndDate,StartDate,EndDate,ActAmount,EstAmount,ClientApproval,AdminApproval,ProjCurrentPhase,ClientID,ProjIsFlagged")] Project project, string[] selectedLabors)
        {
            var projectToUpdate = await _context.Projects
                .Include(p => p.Client)
                .Include(p => p.ProjectLabours)
                .ThenInclude(p => p.LabourRequirement)
                .SingleOrDefaultAsync(p => p.ID == id);

            if(projectToUpdate == null)
            {
                return NotFound();
            }

            UpdateProjectLabours(selectedLabors, projectToUpdate);

            if(await TryUpdateModelAsync<Project>(projectToUpdate,"",
                    p=>p.Name, p=>p.ProjSite,p=>p.ProjBidDate,p=>p.EstStartDate,
                    p=>p.EstEndDate, p => p.StartDate, p => p.EndDate, p => p.ActAmount,
                    p => p.EstAmount, p => p.ClientApproval, p => p.AdminApproval,
                    p => p.ProjCurrentPhase, p => p.ProjIsFlagged))
            {
                try
                {
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (RetryLimitExceededException /* dex */)
                {
                    ModelState.AddModelError("", "Unable to save changes after multiple attempts. Try again, and if the problem persists, see your system administrator.");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(projectToUpdate.ID))
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
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
                }
            }


            if (id != project.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(project);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectExists(project.ID))
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
            PopulateAssignedLaborData(projectToUpdate);
            ViewData["ClientID"] = new SelectList(_context.Clients, "ID", "Address", project.ClientID);
            return View(projectToUpdate);
        }

        // GET: Projects/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Projects
                .Include(p => p.Client)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var project = await _context.Projects.FindAsync(id);
            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private void PopulateAssignedLaborData(Project project)
        {
            var allLabors = _context.LabourRequirements;
            var projLabors = new HashSet<int>
                (project.ProjectLabours.Select(p => p.LabourReqID));
            var selectedLabor = new List<LabourReqVM>();
            var availableLabor = new List<LabourReqVM>();

            foreach (var l in allLabors)
            {
                if(projLabors.Contains(l.ID))
                {
                    selectedLabor.Add(new LabourReqVM
                    {
                        ID = l.ID,
                        DisplayText = l.Task.Description
                        + ", " + l.EstHours.ToString()
                        + ",  " + l.EstDate.ToString()
                        + ", " + l.Team.Phase
                        + (string.IsNullOrEmpty(l.Date.ToString())? " " : (" " + l.Date.ToString()))
                        + (string.IsNullOrEmpty(l.Hours.ToString()) ? " " : (" " + l.Hours.ToString()))
                        + (string.IsNullOrEmpty(l.Comments) ? " " : (" " + l.Comments))
                       
                    });
                }
                else
                {
                    availableLabor.Add(new LabourReqVM
                    {
                        ID = l.ID,
                        DisplayText = l.Task.Description
                        + ", " + l.EstHours.ToString()
                        + ",  " + l.EstDate.ToString()
                        + ", " + l.Team.Phase
                        + (string.IsNullOrEmpty(l.Date.ToString()) ? " " : (" " + l.Date.ToString()))
                        + (string.IsNullOrEmpty(l.Hours.ToString()) ? " " : (" " + l.Hours.ToString()))
                        + (string.IsNullOrEmpty(l.Comments) ? " " : (" " + l.Comments))
                    });
                }
            }
            ViewData["selLabors"] = new MultiSelectList(selectedLabor.OrderBy(s => s.DisplayText), "ID", "DisplayText");
            ViewData["availLabors"] = new MultiSelectList(availableLabor.OrderBy(s => s.DisplayText), "ID", "DisplayText");
        }
        private void UpdateProjectLabours(string[] selectedLabors, Project projectToUpdate)
        {
            if(selectedLabors == null)
            {
                projectToUpdate.ProjectLabours = new List<ProjectLabour>();
                return;

            }
            var selectedLaborsHS = new HashSet<string>(selectedLabors);
            var projLabors = new HashSet<int>
                             (projectToUpdate.ProjectLabours.Select(p => p.LabourReqID));

            foreach(var l in _context.LabourRequirements)
            {
                if (selectedLaborsHS.Contains(l.ID.ToString()))
                {
                    if (!projLabors.Contains(l.ID))
                    {
                        projectToUpdate.ProjectLabours.Add(new ProjectLabour
                        {
                            LabourReqID = l.ID,
                            ProjectID = projectToUpdate.ID

                        });
                    }
                }
                else
                {
                    if (projLabors.Contains(l.ID))
                    {
                        ProjectLabour labourToRemove = projectToUpdate.ProjectLabours.SingleOrDefault(p => p.LabourReqID == l.ID);
                        _context.Remove(labourToRemove);
                       
                    }
                        
                }
                      
            }
            
        }    

        private bool ProjectExists(int id)
        {
            return _context.Projects.Any(e => e.ID == id);
        }
    }
}
