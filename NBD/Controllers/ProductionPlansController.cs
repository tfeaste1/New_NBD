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
    public class ProductionPlansController : Controller
    {
        private readonly NBDContext _context;

        public ProductionPlansController(NBDContext context)
        {
            _context = context;
        }

        // GET: ProductionPlans
        public async Task<IActionResult> Index()
        {
            var nBDContext = _context.ProductionPlan
                .Include(p => p.Project)
                .Include(p => p.Team)
                .Include(p => p.ProdPlanLabours) .ThenInclude(pl => pl.LabourRequirement)
                .Include(p=>p.ProdPlanMaterials) .ThenInclude(pm => pm.MaterialRequirement);
            return View(await nBDContext.ToListAsync());
        }

        // GET: ProductionPlans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productionPlan = await _context.ProductionPlan
                .Include(p => p.Project)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (productionPlan == null)
            {
                return NotFound();
            }

            return View(productionPlan);
        }

        // GET: ProductionPlans/Create
        public IActionResult Create()
        {
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name");
            ViewData["TeamID"] = new SelectList(_context.Teams, "ID", "TeamName");
            return View();
        }

        // POST: ProductionPlans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ProjectID,TeamID,LabourReq,MaterialReq")] ProductionPlan productionPlan, string[] selectedLrequirements, string[] selectedRequirements)
        {
            try
            {
                if (selectedLrequirements != null)
                {
                    productionPlan.ProdPlanLabours = new List<ProdPlanLabour>();
                    foreach (var labour in selectedLrequirements)
                    {
                        var lrequirementToAdd = new ProdPlanLabour
                        {
                            ProdPlanID = productionPlan.ID,
                            LabourReqID = int.Parse(labour)
                        };
                        productionPlan.ProdPlanLabours.Add(lrequirementToAdd);
                    }
                }


                if (selectedRequirements != null)
                {
                    productionPlan.ProdPlanMaterials = new List<ProdPlanMaterial>();
                    foreach (var material in selectedRequirements)
                    {
                        var requirementToAdd = new ProdPlanMaterial
                        {
                            ProdPlanID = productionPlan.ID,
                            MaterialReqID = int.Parse(material)
                        };
                        productionPlan.ProdPlanMaterials.Add(requirementToAdd);
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
                _context.Add(productionPlan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            PopulateAssignedLabourReqData(productionPlan);
            PopulateAssignedMaterialReqData(productionPlan);
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name", productionPlan.ProjectID);
            ViewData["TeamID"] = new SelectList(_context.Teams, "ID", "TeamName", productionPlan.TeamID);
            return View(productionPlan);
        }

        // GET: ProductionPlans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productionPlan = await _context.ProductionPlans
                .Include(p => p.ProdPlanMaterials)
                 .ThenInclude(p => p.MaterialRequirement)
                .Include(p => p.ProdPlanLabours)
                .ThenInclude(p => p.LabourRequirement)
                .AsNoTracking()
                .SingleOrDefaultAsync(p => p.ID == id);
            if (productionPlan == null)
            {
                return NotFound();
            }

            PopulateAssignedLabourReqData(productionPlan);
            PopulateAssignedMaterialReqData(productionPlan);
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name", productionPlan.ProjectID);
            ViewData["TeamID"] = new SelectList(_context.Teams, "ID", "TeamName", productionPlan.TeamID);
            return View(productionPlan);
        }

        // POST: ProductionPlans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ProjectID,TeamID,LabourReq,MaterialReq")] ProductionPlan productionPlan, string[] selectedLrequirements, string[] selectedRequirements)
        {
            if (id != productionPlan.ID)
            {
                return NotFound();
            }
            var pPlanToUpdate = await _context.ProductionPlans
               .Include(p => p.ProdPlanMaterials)
                .ThenInclude(p => p.MaterialRequirement)
               .Include(p => p.ProdPlanLabours)
               .ThenInclude(p => p.LabourRequirement)
               .AsNoTracking()
               .SingleOrDefaultAsync(p => p.ID == id);
           
            UpdateLabourRequirements(selectedLrequirements, pPlanToUpdate);
            UpdateMaterialRequirements(selectedRequirements, pPlanToUpdate);

            if (await TryUpdateModelAsync<ProductionPlan>(pPlanToUpdate, "", p => p.ProjectID, p => p.TeamID))
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
                    if (!ProductionPlanExists(pPlanToUpdate.ID))
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
                    _context.Update(productionPlan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductionPlanExists(productionPlan.ID))
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

            PopulateAssignedLabourReqData(pPlanToUpdate);
            PopulateAssignedMaterialReqData(pPlanToUpdate);
            ViewData["ProjectID"] = new SelectList(_context.Projects, "ID", "Name", productionPlan.ProjectID);
            ViewData["TeamID"] = new SelectList(_context.Teams, "ID", "TeamName", productionPlan.TeamID);
            return View(productionPlan);
        }

        // GET: ProductionPlans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productionPlan = await _context.ProductionPlan
                .Include(p => p.Project)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (productionPlan == null)
            {
                return NotFound();
            }

            return View(productionPlan);
        }

        // POST: ProductionPlans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var productionPlan = await _context.ProductionPlan.FindAsync(id);
            _context.ProductionPlan.Remove(productionPlan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private void PopulateAssignedLabourReqData(ProductionPlan productionPlan)
        {
            var allLrequirements = _context.LabourRequirements;
            var pLrequirements = new HashSet<int>(productionPlan.ProdPlanLabours.Select(p => p.LabourReqID));
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

                    }); ;
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
            ViewData["selOptslpp"] = new MultiSelectList(selectedl.OrderBy(s => s.Description), "ID", "Description");
            ViewData["availOptslpp"] = new MultiSelectList(availablel.OrderBy(s => s.Description), "ID", "Description");
        }
        private void UpdateLabourRequirements(string[] selectedLrequirements, ProductionPlan pPlanToUpdate)
        {
            if (selectedLrequirements == null)
            {
                pPlanToUpdate.ProdPlanLabours = new List<ProdPlanLabour>();
                return;
            }
            var selectedLrequirementHS = new HashSet<string>(selectedLrequirements);
            var labourLRequirementsHS = new HashSet<int>
            (pPlanToUpdate.ProdPlanLabours.Select(i => i.LabourReqID));
            foreach (var labour in _context.LabourRequirements)
            {
                if (selectedLrequirementHS.Contains(labour.ID.ToString()))
                {
                    if (!labourLRequirementsHS.Contains(labour.ID))
                    {
                        pPlanToUpdate.ProdPlanLabours.Add(new ProdPlanLabour
                        {
                            ProdPlanID = pPlanToUpdate.ID,
                            LabourReqID = labour.ID
                        });
                    }
                    else
                    {
                        if (labourLRequirementsHS.Contains(labour.ID))
                        {
                            ProdPlanLabour summaryToRemove = pPlanToUpdate.ProdPlanLabours
                                                                           .SingleOrDefault(s => s.LabourReqID == labour.ID);
                            _context.Remove(summaryToRemove);
                        }
                    }
                }
            }
        }

        private void PopulateAssignedMaterialReqData(ProductionPlan productionPlan)
        {
            var allRequirements = _context.MaterialRequirements;
            var pRequirements = new HashSet<int>(productionPlan.ProdPlanMaterials.Select(p => p.MaterialReqID));
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
            ViewData["selOptsmpp"] = new MultiSelectList(selectedm.OrderBy(s => s.MaterialName), "ID", "MaterialName");
            ViewData["availOptsmpp"] = new MultiSelectList(availablem.OrderBy(s => s.MaterialName), "ID", "MaterialName");
        }
        private void UpdateMaterialRequirements(string[] selectedRequirements, ProductionPlan pPlanToUpdate)
        {
            if (selectedRequirements == null)
            {
                pPlanToUpdate.ProdPlanMaterials = new List<ProdPlanMaterial>();
                return;
            }
            var selectedRequirementsHS = new HashSet<string>(selectedRequirements);
            var materialReqsHS = new HashSet<int>
            (pPlanToUpdate.ProdPlanMaterials.Select(r => r.MaterialReqID));
            foreach (var material in _context.MaterialRequirements)
            {
                if (selectedRequirementsHS.Contains(material.ID.ToString()))
                {
                    if (!materialReqsHS.Contains(material.ID))
                    {
                        pPlanToUpdate.ProdPlanMaterials.Add(new ProdPlanMaterial
                        {
                            ProdPlanID = pPlanToUpdate.ID,
                            MaterialReqID = material.ID
                        });
                    }
                    else
                    {
                        if (materialReqsHS.Contains(material.ID))
                        {
                            ProdPlanMaterial requirementToRemove = pPlanToUpdate.ProdPlanMaterials
                                                                           .SingleOrDefault(r => r.MaterialReqID == material.ID);
                            _context.Remove(requirementToRemove);
                        }
                    }
                }
            }
        }


        private bool ProductionPlanExists(int id)
        {
            return _context.ProductionPlan.Any(e => e.ID == id);
        }
    }
}
