using System;
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
            var projects = from p in _context.Projects
                            .Include(p => p.Client)
                            .Include(p => p.ProjectInventories).ThenInclude(pi=> pi.Inventory)
                            select p;
            return View(await projects.ToListAsync());
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
                .Include(p => p.ProjectInventories).ThenInclude(pi => pi.Inventory)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (project == null)
            {
                return NotFound();
            }

            return View(project);
        }

        // GET: Projects/Create
        [Authorize(Roles = "Admin,Manager")]
        public IActionResult Create()
        {
            //Add all (unchecked) Conditions to ViewBag
            var project = new Project();
            project.ProjectInventories = new List<ProjectInventory>();
            PopulateAssignedInventory(project);
            OrderbyC(project);
            return View();

        }

        // POST: Projects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Create([Bind("ID,Name,StartDate,EndDate,EstStartDate, EstEndDate, BidAmount, Amount,ClientApproval,AdminApproval,ProdBidSite,ClientID")] Project project, String[] selectedInvetory)
        {
            try
            {
                //Add the selected inventory
                if (selectedInvetory != null)
                {
                    project.ProjectInventories = new List<ProjectInventory>();
                    foreach (var inventory in selectedInvetory)
                    {
                        var inventoryToAdd = new ProjectInventory { ProjectID = project.ID, InventoryID = int.Parse(inventory) };
                        project.ProjectInventories.Add(inventoryToAdd);
                    }
                }
                if (ModelState.IsValid)
                {
                    _context.Add(project);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
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

            PopulateAssignedInventory(project);
            OrderbyC(project);
            return View(project);
        }


        // GET: Projects/Edit/5
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var project = await _context.Projects
                .Include(p=> p.ProjectInventories)
                .AsNoTracking()
               .SingleOrDefaultAsync(p => p.ID == id);
            if (project == null)
            {
                return NotFound();
            }
            PopulateAssignedInventory(project);
            OrderbyC(project);
            return View(project);
        }
        // POST: Projects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,StartDate,EndDate,EstStartDate, EstEndDate, BidAmount,Amount,ClientApproval,AdminApproval,ProdBidSite,TeamID")] Project project, string[] selectedInventory)
        {
            var projectToUpdate = await _context.Projects
                 .Include(p => p.Client)
                 .Include(p => p.Teams)
                 .Include(p => p.ProjectInventories)
                 .ThenInclude(p => p.Inventory)
                 .SingleOrDefaultAsync(p => p.ID == id);
            //Check that you got it or exit with a not found error
            if (projectToUpdate == null)
            {
                return NotFound();
            }

            //Update the medical history
            UpdateProjectInventory(selectedInventory, projectToUpdate);

            //Try updating it with the values posted
            if (await TryUpdateModelAsync<Project>(projectToUpdate, "",
                p => p.Name,p => p.StartDate, p => p.EndDate, p => p.EstStartDate, p => p.EstEndDate, p => p.Amount, p => p.BidAmount,
                p => p.ProdBidSite, p => p.ClientApproval, p => p.AdminApproval, p => p.ClientID))
            {
                try
                {
                    _context.Update(projectToUpdate);
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
            //Validaiton Error so give the user another chance.
            PopulateAssignedInventory(projectToUpdate);
            OrderbyC(projectToUpdate);
            return View(projectToUpdate);
        
    }

       private void PopulateAssignedInventory(Project project)
        {
            var allInventories = _context.Inventories;
            var docInventories = new HashSet<int>(project.ProjectInventories.Select(p => p.InventoryID));
            var selected = new List<AssignedInventory>();
            var available = new List<AssignedInventory>();
            foreach (var i in allInventories)
            {
                if (docInventories.Contains(i.ID))
                {
                    selected.Add(new AssignedInventory
                    {
                        ID = i.ID,
                        DisplayText = i.Name
                    });
                }
                else
                {
                    available.Add(new AssignedInventory
                    {
                        ID = i.ID,
                        DisplayText = i.Name
                    });
                }
            }

            ViewData["selOpts"] = new MultiSelectList(selected.OrderBy(s => s.DisplayText), "ID", "DisplayText");
            ViewData["availOpts"] = new MultiSelectList(available.OrderBy(s => s.DisplayText), "ID", "DisplayText");
        }
        private void UpdateProjectInventory(string[] selectedOptions, Project projectToUpdate)
        {
            if (selectedOptions == null)
            {
                projectToUpdate.ProjectInventories = new List<ProjectInventory>();
                return;
            }

            var selectedInventoryHS = new HashSet<string>(selectedOptions);
            var projectInventoryHS = new HashSet<int>
                (projectToUpdate.ProjectInventories.Select(p => p.InventoryID));//IDs of the currently selected conditions
            foreach (var inventory in _context.Inventories)
            {
                if (selectedInventoryHS.Contains(inventory.ID.ToString()))
                {
                    if (!projectInventoryHS.Contains(inventory.ID))
                    {
                        projectToUpdate.ProjectInventories.Add(new ProjectInventory { ProjectID = projectToUpdate.ID, InventoryID = inventory.ID });
                    }
                }
                else
                {
                    if (projectInventoryHS.Contains(inventory.ID))
                    {
                        ProjectInventory inventoryToRemove = projectToUpdate.ProjectInventories.SingleOrDefault(p => p.InventoryID == inventory.ID);
                        _context.Remove(inventoryToRemove);
                    }
                }
            }
        }
        private void OrderbyC(Project project)
        {
            ViewData["ClientID"] = new SelectList(_context.Clients.OrderBy(c => c.CompanyName), "ID","Company Name",project.ClientID);
        }

        private bool ProjectExists(int id)
        {
            return _context.Projects.Any(e => e.ID == id);
        }
    }
}
    

