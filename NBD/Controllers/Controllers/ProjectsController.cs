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
            var project = new Project();
            project.LabourSummaries = new List<LabourSummary>();
            project.MaterialRequirements = new List<MaterialRequirement>();
            project.ProductionTools = new List<ProductionTool>();
            project.Teams = new List<Team>();

            PopulateAssignedLabourSumData(project);
            PopulateAssignedMaterialReqData(project);
            PopulateAssignedProdToolData(project);
            PopulateAssignedTeamData(project);
            ViewData["ClientID"] = new SelectList(_context.Clients, "ID", "CompanyName");
            return View();
        }

        // POST: Projects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,ProjSite,ProjBidDate,EstStartDate,EstEndDate,StartDate,EndDate,ActAmount,EstAmount,ClientApproval,AdminApproval,ProjCurrentPhase,ClientID,ProjIsFlagged")] Project project, string[] selectedSummaries, string[] selectedRequirements, string[] selectedTools, string[] selectedTeams)
        {
            try
            {
                if (selectedSummaries != null)
                {
                    project.LabourSummaries = new List<LabourSummary>();
                    foreach (var department in selectedSummaries)
                    {
                        var summaryToAdd = new LabourSummary
                        {
                            ProjectID = project.ID,
                            DepartmentID = int.Parse(department)
                        };
                        project.LabourSummaries.Add(summaryToAdd);
                    }
                }
                if (selectedTeams != null)
                {
                    project.Teams = new List<Team>();
                    foreach (var employee in selectedTeams)
                    {
                        var teamToAdd = new Team
                        {
                            ProjectID = project.ID,
                            EmployeeID = int.Parse(employee)
                        };
                        project.Teams.Add(teamToAdd);
                    }
                }
                if (selectedTools != null)
                {
                    project.ProductionTools = new List<ProductionTool>();
                    foreach (var tool in selectedTools)
                    {
                        var toolToAdd = new ProductionTool
                        {
                            ProjectID = project.ID,
                            ToolID = int.Parse(tool)
                        };
                        project.ProductionTools.Add(toolToAdd);
                    }
                }
                if (selectedRequirements != null)
                {
                    project.MaterialRequirements = new List<MaterialRequirement>();
                    foreach (var inventory in selectedRequirements)
                    {
                        var requirementToAdd = new MaterialRequirement
                        {
                            ProjectID = project.ID,
                            InventoryID = int.Parse(inventory)
                        };
                        project.MaterialRequirements.Add(requirementToAdd);
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
                                 
            PopulateAssignedLabourSumData(project);
            PopulateAssignedMaterialReqData(project);
            PopulateAssignedProdToolData(project);
            PopulateAssignedTeamData(project);
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
                .Include(p => p.LabourSummaries)
                .ThenInclude(p => p.Department)
                .Include(p => p.Teams)
                .ThenInclude(p => p.Employee)
                .Include(p => p.ProductionTools)
                .ThenInclude(p => p.Tool)
                .Include(p => p.MaterialRequirements)
                .ThenInclude(p => p.Inventory)
                .AsNoTracking()
                .SingleOrDefaultAsync(p => p.ID == id);
            if (project == null)
            {
                return NotFound();
            }

            PopulateAssignedLabourSumData(project);
            PopulateAssignedMaterialReqData(project);
            PopulateAssignedProdToolData(project);
            PopulateAssignedTeamData(project);
            ViewData["ClientID"] = new SelectList(_context.Clients, "ID", "CompanyName", project.ClientID);
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,ProjSite,ProjBidDate,EstStartDate,EstEndDate,StartDate,EndDate,ActAmount,EstAmount,ClientApproval,AdminApproval,ProjCurrentPhase,ClientID,ProjIsFlagged")] Project project, string[] selectedSummaries, string[] selectedRequirements, string[] selectedTools, string[] selectedTeams)
        {
            var projectToUpdate = await _context.Projects
              .Include(p => p.Client)
              .Include(p => p.LabourSummaries)
              .ThenInclude(p => p.Department)
              .Include(p => p.Teams)
              .ThenInclude(p => p.Employee)
              .Include(p => p.ProductionTools)
              .ThenInclude(p => p.Tool)
              .Include(p => p.MaterialRequirements)
              .ThenInclude(p => p.Inventory)
              .AsNoTracking()
              .SingleOrDefaultAsync(p => p.ID == id);

            if (id != project.ID)
            {
                return NotFound();
            }

            UpdateLabourSummaries(selectedSummaries, projectToUpdate);
            UpdateMaterialRequirements(selectedRequirements, projectToUpdate);
            UpdateProductionTools(selectedTools, projectToUpdate);
            UpdateTeams(selectedTeams, projectToUpdate);
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

            PopulateAssignedLabourSumData(projectToUpdate);
            PopulateAssignedMaterialReqData(projectToUpdate);
            PopulateAssignedProdToolData(projectToUpdate);
            PopulateAssignedTeamData(projectToUpdate);
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

        private void PopulateAssignedLabourSumData(Project project)
        {
            var allSummaries = _context.Departments;
            var pSummaries = new HashSet<int>(project.LabourSummaries.Select(p => p.DepartmentID));
            var selectedl = new List<LabourSumVM>();
            var availablel = new List<LabourSumVM>();
            foreach (var s in allSummaries)
            {
                if (pSummaries.Contains(s.ID))
                {
                    selectedl.Add(new LabourSumVM
                    {
                        ID = s.ID,
                        DisplayText = s.Description
                    });
                }
                else
                {
                    availablel.Add(new LabourSumVM
                    {
                        ID = s.ID,
                        DisplayText = s.Description
                    });
                }
            }
            ViewData["selOptsl"] = new MultiSelectList(selectedl.OrderBy(s => s.DisplayText), "ID", "DisplayText");
            ViewData["availOptsl"] = new MultiSelectList(availablel.OrderBy(s => s.DisplayText), "ID", "DisplayText");
        }
        private void UpdateLabourSummaries (string[] selectedSummaries, Project projectToUpdate)
        {
            if(selectedSummaries == null)
            {
                projectToUpdate.LabourSummaries = new List<LabourSummary>();
                return;
            }
            var selectedSummaryHS = new HashSet<string>(selectedSummaries);
            var labourSummariesHS = new HashSet<int>
            (projectToUpdate.LabourSummaries.Select(i => i.DepartmentID));
            foreach( var department in _context.Departments)
            {
                if (selectedSummaryHS.Contains(department.ID.ToString()))
                {
                    if(!labourSummariesHS.Contains(department.ID))
                    {
                        projectToUpdate.LabourSummaries.Add(new LabourSummary
                        {
                            ProjectID = projectToUpdate.ID, DepartmentID = department.ID
                        });
                    }
                    else
                    {
                        if(labourSummariesHS.Contains(department.ID))
                        {
                            LabourSummary summaryToRemove = projectToUpdate.LabourSummaries
                                                                           .SingleOrDefault(s => s.DepartmentID == department.ID);
                            _context.Remove(summaryToRemove);
                        }
                    }
                }
            }
        }
        private void PopulateAssignedTeamData(Project project)
        {
            var allTeams = _context.Employees;
            var pTeams = new HashSet<int>(project.Teams.Select(p => p.EmployeeID));
            var selected = new List<TeamVM>();
            var available = new List<TeamVM>();
            foreach (var t in allTeams)
            {
              if(pTeams.Contains(t.ID))
                {
                    selected.Add(new TeamVM
                    {
                        ID = t.ID,
                        DisplayText = t.FullName
                    });
                }
                else
                {
                    available.Add(new TeamVM
                    {
                        ID = t.ID,
                        DisplayText = t.FullName
                    });
                }
            }
            ViewData["selOptst"] = new MultiSelectList(selected.OrderBy(s => s.DisplayText), "ID", "DisplayText");
            ViewData["availOptst"] = new MultiSelectList(available.OrderBy(s => s.DisplayText), "ID", "DisplayText");
        }
        private void UpdateTeams(string[] selectedTeams, Project projectToUpdate)
        {
            if (selectedTeams == null)
            {
                projectToUpdate.Teams = new List<Team>();
                return;
            }
            var selectedTeamHS = new HashSet<string>(selectedTeams);
            var teamsHS = new HashSet<int>
            (projectToUpdate.Teams.Select(e => e.EmployeeID));
            foreach (var employee in _context.Employees)
            {
                if (selectedTeamHS.Contains(employee.ID.ToString()))
                {
                    if (!teamsHS.Contains(employee.ID))
                    {
                        projectToUpdate.Teams.Add(new Team
                        {
                            ProjectID = projectToUpdate.ID,
                            EmployeeID = employee.ID
                        });
                    }
                    else
                    {
                        if (teamsHS.Contains(employee.ID))
                        {
                            Team teamToRemove = projectToUpdate.Teams
                                                               .SingleOrDefault(t => t.EmployeeID == employee.ID);
                            _context.Remove(teamToRemove);
                        }
                    }
                }
            }
        }
        private void PopulateAssignedProdToolData(Project project)
        {
            var allTools = _context.Tools;
            var pTools = new HashSet<int>(project.ProductionTools.Select(p => p.ToolID));
            var selectedp = new List<ProdToolVM>();
            var availablep = new List<ProdToolVM>();
            foreach (var p in allTools)
            {
                if (pTools.Contains(p.ID))
                {
                    selectedp.Add(new ProdToolVM
                    {
                        ID = p.ID,
                        DisplayText = p.Description
                    });
                }
                else
                {
                    availablep.Add(new ProdToolVM
                    {
                        ID = p.ID,
                        DisplayText = p.Description
                    });
                }
            }
            ViewData["selOptsp"] = new MultiSelectList(selectedp.OrderBy(s => s.DisplayText), "ID", "DisplayText");
            ViewData["availOptsp"] = new MultiSelectList(availablep.OrderBy(s => s.DisplayText), "ID", "DisplayText");
        }
        private void UpdateProductionTools (string[] selectedTools, Project projectToUpdate)
        {
            if (selectedTools == null)
            {
                projectToUpdate.ProductionTools = new List<ProductionTool>();
                return;
            }
            var selectedToolHS = new HashSet<string>(selectedTools);
            var prodToolsHS = new HashSet<int>
            (projectToUpdate.ProductionTools.Select(t => t.ToolID));
            foreach (var tool in _context.Tools)
            {
                if (selectedToolHS.Contains(tool.ID.ToString()))
                {
                    if (!prodToolsHS.Contains(tool.ID))
                    {
                        projectToUpdate.ProductionTools.Add(new ProductionTool
                        {
                            ProjectID = projectToUpdate.ID,
                            ToolID = tool.ID
                        });
                    }
                    else
                    {
                        if (prodToolsHS.Contains(tool.ID))
                        {
                            ProductionTool toolToRemove = projectToUpdate.ProductionTools
                                                                           .SingleOrDefault(t => t.ToolID == tool.ID);
                            _context.Remove(toolToRemove);
                        }
                    }
                }
            }
        }
        private void PopulateAssignedMaterialReqData(Project project)
        {
            var allRequirements = _context.Inventories;
            var pRequirements = new HashSet<int>(project.MaterialRequirements.Select(p => p.InventoryID));
            var selectedm = new List<MaterialReqVM>();
            var availablem = new List<MaterialReqVM>();
            foreach (var r in allRequirements)
            {
                if (pRequirements.Contains(r.ID))
                {
                    selectedm.Add(new MaterialReqVM
                    {
                        ID = r.ID,
                        DisplayText = r.MaterialID.ToString()
                    });
                }
                else
                {
                    availablem.Add(new MaterialReqVM
                    {
                        ID = r.ID,
                        DisplayText = r.MaterialID.ToString()
                    });
                }
            }
            ViewData["selOptsm"] = new MultiSelectList(selectedm.OrderBy(s => s.DisplayText), "ID", "DisplayText");
            ViewData["availOptsm"] = new MultiSelectList(availablem.OrderBy(s => s.DisplayText), "ID", "DisplayText");
        }
        private void UpdateMaterialRequirements(string[] selectedRequirements, Project projectToUpdate)
        {
            if (selectedRequirements == null)
            {
                projectToUpdate.MaterialRequirements = new List<MaterialRequirement>();
                return;
            }
            var selectedRequirementsHS = new HashSet<string>(selectedRequirements);
            var materialReqsHS = new HashSet<int>
            (projectToUpdate.MaterialRequirements.Select(r => r.InventoryID));
            foreach (var inventory in _context.Inventories)
            {
                if (selectedRequirementsHS.Contains(inventory.ID.ToString()))
                {
                    if (!materialReqsHS.Contains(inventory.ID))
                    {
                        projectToUpdate.MaterialRequirements.Add(new MaterialRequirement
                        {
                            ProjectID = projectToUpdate.ID,
                            InventoryID = inventory.ID
                        });
                    }
                    else
                    {
                        if (materialReqsHS.Contains(inventory.ID))
                        {
                            MaterialRequirement requirementToRemove = projectToUpdate.MaterialRequirements
                                                                           .SingleOrDefault(r => r.InventoryID == inventory.ID);
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
