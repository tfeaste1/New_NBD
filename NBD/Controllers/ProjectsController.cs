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
        public async Task<IActionResult> Index(int id)
        {
            var nBDContext = _context.Projects.Include(p => p.Client);
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
                .Include(p=>p.ProjectLabours)
                .ThenInclude(p=>p.LabourRequirement)
                .Include(p=>p.ProjectMaterials)
                .ThenInclude(p=>p.MaterialRequirement)
                .AsNoTracking()
                .SingleOrDefaultAsync(p => p.ID == id);
            if (project == null)
            {
                return NotFound();
            }

            PopulateAssignedLabourReqData(project);
            PopulateAssignedMaterialReqData(project);
            return View(project);
        }

        // GET: Projects/Create
        public IActionResult Create()
        {
            var project = new Project();
            project.ProjectLabours = new List<ProjectLabour>();
            project.ProjectMaterials = new List<ProjectMaterial>();
            

            PopulateAssignedLabourReqData(project);
            PopulateAssignedMaterialReqData(project);
           
            ViewData["ClientID"] = new SelectList(_context.Clients, "ID", "CompanyName");
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,ProjSite,ProjBidDate,EstStartDate,EstEndDate,StartDate,EndDate,ActAmount,EstAmount,ClientApproval,AdminApproval,ProjCurrentPhase,ClientID,ProjIsFlagged")] Project project, string[] selectedLrequirements, string[] selectedRequirements)
        {
            try
            {
                if (selectedLrequirements != null)
                {
                    project.ProjectLabours = new List<ProjectLabour>();
                    foreach (var labour in selectedLrequirements)
                    {
                        var lrequirementToAdd = new ProjectLabour
                        {
                            ProjectID = project.ID,
                            LabourReqID = int.Parse(labour)
                        };
                        project.ProjectLabours.Add(lrequirementToAdd);
                    }
                }
          
             
                if (selectedRequirements != null)
                {
                    project.ProjectMaterials = new List<ProjectMaterial>();
                    foreach (var material in selectedRequirements)
                    {
                        var requirementToAdd = new ProjectMaterial
                        {
                            ProjectID = project.ID,
                            MaterialReqID = int.Parse(material)
                        };
                        project.ProjectMaterials.Add(requirementToAdd);
                    }
                }
            }
            catch (RetryLimitExceededException /* dex */)
            {
                ModelState.AddModelError("", "Unable to save changes after multiple attempts. Try again, and if the problem persists, see your system administrator.");
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Unknown error!");
            }
            if (ModelState.IsValid)
            {
                _context.Add(project);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
                                 
            PopulateAssignedLabourReqData(project);
            PopulateAssignedMaterialReqData(project);
            ViewData["ClientID"] = new SelectList(_context.Clients, "ID", "CompanyName", project.ClientID);
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
                .Include(p => p.ProjectMaterials)
                .ThenInclude(p => p.MaterialRequirement)
                .Include(p => p.ProjectLabours)
                .ThenInclude(p => p.LabourRequirement)
                .AsNoTracking()
                .SingleOrDefaultAsync(p => p.ID == id);
            if (project == null)
            {
                return NotFound();
            }

            PopulateAssignedLabourReqData(project);
            PopulateAssignedMaterialReqData(project);
            
            ViewData["ClientID"] = new SelectList(_context.Clients, "ID", "CompanyName", project.ClientID);
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,ProjSite,ProjBidDate,EstStartDate,EstEndDate,StartDate,EndDate,ActAmount,EstAmount,ClientApproval,AdminApproval,ProjCurrentPhase,ClientID,ProjIsFlagged")] Project project, string[] selectedLrequirements, string[] selectedRequirements)
        {
            var projectToUpdate = await _context.Projects
              .Include(p => p.Client)
              .Include(p => p.ProjectLabours)
              .ThenInclude(p => p.LabourRequirement)
              .Include(p => p.ProjectMaterials)
              .ThenInclude(p => p.MaterialRequirement)
              .AsNoTracking()
              .SingleOrDefaultAsync(p => p.ID == id);

            if (id != project.ID)
            {
                return NotFound();
            }

            UpdateLabourRequirements(selectedLrequirements, projectToUpdate);
            UpdateMaterialRequirements(selectedRequirements, projectToUpdate);
           
            if(await TryUpdateModelAsync<Project>(projectToUpdate, "", p => p.Name, p => p.ProjSite, p => p.ProjBidDate, 
                p => p.EstStartDate, p => p.EstEndDate, p => p.StartDate, p => p.EndDate, p => p.EstAmount, p => p.ActAmount,
                p => p.ClientApproval, p => p.AdminApproval, p => p.ClientID))
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

            PopulateAssignedLabourReqData(projectToUpdate);
            PopulateAssignedMaterialReqData(projectToUpdate);
            ViewData["ClientID"] = new SelectList(_context.Clients, "ID", "CompanyName", project.ClientID);
            return View(project);
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

        private void PopulateAssignedLabourReqData(Project project)
        {
            var allLrequirements = _context.LabourRequirements;
            var pLrequirements = new HashSet<int>(project.ProjectLabours.Select(p => p.LabourReqID));
            var selectedl = new List<LabourReqVM>();
            var availablel = new List<LabourReqVM>();
            foreach (var r in allLrequirements)
            {
                if (pLrequirements.Contains(r.ID))
                {
                    selectedl.Add(new LabourReqVM
                    {
                        ID = r.ID,
                        Description = r.Team.Employee.Department.Description,
                        Hours = r.Hours,
                        CostPerHour = r.Team.Employee.Department.Cost,
                        Cost = r.Hours * r.Team.Employee.Department.Cost,
                        Time = r.Date,
                        Task = r.Task.Description

                    }) ;
                }
                else
                {
                    availablel.Add(new LabourReqVM
                    {
                        ID = r.ID,
                        Description = r.Team.Employee.Department.Description,
                        Hours = r.Hours,
                        CostPerHour = r.Team.Employee.Department.Cost,
                        Cost = r.Hours * r.Team.Employee.Department.Cost,
                        Time = r.Date,
                        Task = r.Task.Description
                    });
                }
            }
            ViewData["selOptsl"] = new MultiSelectList(selectedl.OrderBy(s => s.Description), "ID", "Description");
            ViewData["availOptsl"] = new MultiSelectList(availablel.OrderBy(s => s.Description), "ID", "Description");
        }
        private void UpdateLabourRequirements (string[] selectedLrequirements, Project projectToUpdate)
        {
            if(selectedLrequirements == null)
            {
                projectToUpdate.ProjectLabours = new List<ProjectLabour>();
                return;
            }
            var selectedLrequirementHS = new HashSet<string>(selectedLrequirements);
            var labourLRequirementsHS = new HashSet<int>
            (projectToUpdate.ProjectLabours.Select(i => i.LabourReqID));
            foreach( var labour in _context.LabourRequirements)
            {
                if (selectedLrequirementHS.Contains(labour.ID.ToString()))
                {
                    if(!labourLRequirementsHS.Contains(labour.ID))
                    {
                        projectToUpdate.ProjectLabours.Add(new ProjectLabour
                        {
                            ProjectID = projectToUpdate.ID, LabourReqID = labour.ID
                        });
                    }
                    else
                    {
                        if(labourLRequirementsHS.Contains(labour.ID))
                        {
                            ProjectLabour summaryToRemove = projectToUpdate.ProjectLabours
                                                                           .SingleOrDefault(s => s.LabourReqID == labour.ID);
                            _context.Remove(summaryToRemove);
                        }
                    }
                }
            }
        }
       
        private void PopulateAssignedMaterialReqData(Project project)
        {
            var allRequirements = _context.MaterialRequirements;
            var pRequirements = new HashSet<int>(project.ProjectMaterials.Select(p => p.MaterialReqID));
            var selectedm = new List<MaterialReqVM>();
            var availablem = new List<MaterialReqVM>();
            foreach (var r in allRequirements)
            {
                if (pRequirements.Contains(r.ID))
                {
                    selectedm.Add(new MaterialReqVM
                    {
                        ID = r.ID,
                        MaterialName = r.Inventory.Material.Description,
                        Size = r.Quantity.ToString() + " " + r.Inventory.SizeUnit,
                        NetUnit = r.Inventory.AvgNet,
                        Cost = r.Quantity * r.Inventory.AvgNet
                                       
                    });
                }
                else
                {
                    availablem.Add(new MaterialReqVM
                    {
                        ID = r.ID,
                        MaterialName = r.Inventory.Material.Description,
                        Size = r.Quantity.ToString() + " " + r.Inventory.SizeUnit,
                        NetUnit = r.Inventory.AvgNet,
                        Cost = r.Quantity * r.Inventory.AvgNet
                    });
                }
            }
            ViewData["selOptsm"] = new MultiSelectList(selectedm.OrderBy(s => s.MaterialName), "ID", "MaterialName");
            ViewData["availOptsm"] = new MultiSelectList(availablem.OrderBy(s => s.MaterialName), "ID", "MaterialName");
        }
        private void UpdateMaterialRequirements(string[] selectedRequirements, Project projectToUpdate)
        {
            if (selectedRequirements == null)
            {
                projectToUpdate.ProjectMaterials = new List<ProjectMaterial>();
                return;
            }
            var selectedRequirementsHS = new HashSet<string>(selectedRequirements);
            var materialReqsHS = new HashSet<int>
            (projectToUpdate.ProjectMaterials.Select(r => r.MaterialReqID));
            foreach (var material in _context.MaterialRequirements)
            {
                if (selectedRequirementsHS.Contains(material.ID.ToString()))
                {
                    if (!materialReqsHS.Contains(material.ID))
                    {
                        projectToUpdate.ProjectMaterials.Add(new ProjectMaterial
                        {
                            ProjectID = projectToUpdate.ID,
                            MaterialReqID = material.ID
                        });
                    }
                    else
                    {
                        if (materialReqsHS.Contains(material.ID))
                        {
                            ProjectMaterial requirementToRemove = projectToUpdate.ProjectMaterials
                                                                           .SingleOrDefault(r => r.MaterialReqID == material.ID);
                            _context.Remove(requirementToRemove);
                        }
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
