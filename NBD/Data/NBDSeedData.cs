using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NBD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace NBD.Data
{
    public class NBDSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new NBDContext(
                serviceProvider.GetRequiredService<DbContextOptions<NBDContext>>()))
            {
                if (!context.Departments.Any())
                {
                    context.Departments.AddRange(
                     new Department
                     {
                         Name = "Sales"
                     },

                     new Department
                     {
                         Name = "Design"
                     },

                     new Department
                     {
                         Name = "Production"
                     },

                     new Department
                     {
                         Name = "Administration"
                     });


                    context.SaveChanges();

                }

                if (!context.Clients.Any())
                {
                    context.Clients.AddRange(
                    new Client
                    {
                        FirstName = "Cheryl",
                        LastName = "Brown",
                        CompanyName = "Faith Industries",
                        PhoneNumber = 2896489638,
                        Email = "cbrown@outlook.com",
                        Address = "123 Plum Road",
                        City = "St. Catharines",
                        Province = "Ontario",
                        PostalCode = "L2S1G6"

                    },

                     new Client
                     {
                         FirstName = "Brad",
                         LastName = "Ferguson",
                         CompanyName = "BF Corporation",
                         PhoneNumber = 9056487592,
                         Email = "bferg@gmail.com",
                         Address = "24 Graystone Avenue",
                         City = "Welland",
                         Province = "Ontario",
                         PostalCode = "L3C4R6"
                     },

                     new Client
                     {
                         FirstName = "Robin",
                         LastName = "Jones",
                         CompanyName = "Jones Solutions Inc.",
                         PhoneNumber = 6475869324,
                         Email = "rjones@yahoo.ca",
                         Address = "3 Beacon Road",
                         City = "Toronto",
                         Province = "Ontario",
                         PostalCode = "M2J5H6"
                     });
                    context.SaveChanges();

                }

                if (!context.Employees.Any())
                {
                    context.Employees.AddRange(
                        new Employee
                        {
                            FirstName = "Bob",
                            LastName = "Reinhardt",
                            Email = "breinhardt@nbd.com",
                            PhoneNumber = 4087753652,
                            DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Sales").ID,
                        },
                         new Employee
                         {
                             FirstName = "Rosa",
                             LastName = "Bradley",
                             Email = "rbradley@nbd.com",
                             PhoneNumber = 4087753650,
                             DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Sales").ID,
                         },
                        new Employee
                        {
                            FirstName = "Tamara",
                            LastName = "Bakken",
                            Email = "tbakken@nbd.com",
                            PhoneNumber = 4087753642,
                            DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Design").ID,

                        },
                         new Employee
                         {
                             FirstName = "Paul",
                             LastName = "Saunders",
                             Email = "psaunders@nbd.com",
                             PhoneNumber = 4087753640,
                             DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Design").ID,

                         },


                        new Employee
                        {
                            FirstName = "Monica",
                            LastName = "Goce",
                            Email = "mgoce@nbd.com",
                            PhoneNumber = 4087753692,
                            DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Production").ID,
                        },

                        new Employee
                        {
                            FirstName = "Bert",
                            LastName = "Swenson",
                            Email = "bswenson@nbd.com",
                            PhoneNumber = 4087753689,
                            DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Production").ID,
                        }
                        );
                    context.SaveChanges();
                }
                if (!context.Projects.Any())
                {
                    context.Projects.AddRange(
                        new Project
                        {
                            Name = "Seaway Mall",

                            StartDate = DateTime.Parse("2020-02-01"),
                            EndDate = DateTime.Parse("2020-02-06"),
                            EstStartDate = DateTime.Parse("2020-02-02"),
                            EstEndDate = DateTime.Parse("2020-02-8"),
                            Amount = 7650,
                            BidAmount = 8000,
                            ProdBidSite = "Parking Lot",
                            ClientApproval = true,
                            AdminApproval = true,
                            ClientID = context.Clients.FirstOrDefault(c => c.FirstName == "Cheryl" && c.LastName == "Brown").ID,

                        },

                    new Project
                    {
                        Name = "Vaughn Mills",

                        StartDate = DateTime.Parse("2020-03-25"),
                        EndDate = DateTime.Parse("2020-03-26"),
                        EstStartDate = DateTime.Parse("2020-03-25"),
                        EstEndDate = DateTime.Parse("2020-03-30"),
                        Amount = 8000,
                        BidAmount = 8000,
                        ProdBidSite = "Parking Lot",
                        ClientApproval = false,
                        AdminApproval = true,
                        ClientID = context.Clients.FirstOrDefault(c => c.FirstName == "Robin" && c.LastName == "Jones").ID,



                    });

                    context.SaveChanges();
                }
                if (!context.Teams.Any())
                {
                    context.Teams.AddRange(
                       new Team
                       {
                           TeamName = "Team 1",
                           ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Seaway Mall").ID,
                           EmployeeID = 1//context.Employees.FirstOrDefault(p => p.FirstName == "Bob" && p.LastName == "ReinHardt").ID

                       },
                       new Team
                       {
                           TeamName = "Team 1",
                           ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Seaway Mall").ID,
                           EmployeeID = 2//context.Employees.FirstOrDefault(p => p.FirstName == "Tamara" && p.LastName == "Bakken").ID

                       },
                       new Team
                       {
                           TeamName = "Team 1",
                           ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Seaway Mall").ID,
                           EmployeeID = 3//context.Employees.FirstOrDefault(p => p.FirstName == "Monica" && p.LastName == "Goce").ID

                       },
                       new Team
                       {
                           TeamName = "Team 1",
                           ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Seaway Mall").ID,
                           EmployeeID = 4//context.Employees.FirstOrDefault(p => p.FirstName == "Bert" && p.LastName == "Swanson").ID

                       },

                       new Team
                       {
                           TeamName = "Team 2",
                           ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Vaughn Mills").ID,
                           EmployeeID = 5//context.Employees.FirstOrDefault(p => p.FirstName == "Rosa" && p.LastName == "Bradley").ID

                       },
                       new Team
                       {
                           TeamName = "Team 2",
                           ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Vaughn Mills").ID,
                           EmployeeID = 2// context.Employees.FirstOrDefault(p => p.FirstName == "Paul" && p.LastName == "Saunders").ID

                       },
                       new Team
                       {
                           TeamName = "Team 2",
                           ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Vaughn Mills").ID,
                           EmployeeID = 3//context.Employees.FirstOrDefault(p => p.FirstName == "Monica" && p.LastName == "Goce").ID

                       },
                       new Team
                       {
                           TeamName = "Team 2",
                           ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Vaughn Mills").ID,
                           EmployeeID = 6//context.Employees.FirstOrDefault(p => p.FirstName == "Bert" && p.LastName == "Swanson").ID

                       });
                    context.SaveChanges();
                }

                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(
                        new Category
                        {
                            Name = "Pottery"
                        },
                        new Category
                        {
                            Name = "Plants"
                        },
                        new Category
                        {
                            Name = "Materials"
                        },
                        new Category
                        {
                            Name = "Tools"
                        }
                            );
                    context.SaveChanges();
                }

                if (!context.ProjectInventories.Any())
                {
                    string[] inventorynames = new string[] { "Daffodil", "Rose", "Golden Dewdrop", "Tulip", "Sunflower", "Fertilizer", "Mulch", "Rake", "Shovel", "Wheelbarrow" };
                    foreach (string i in inventorynames)
                    {
                        Inventory iv = new Inventory
                        {
                            Name = i
                        };
                        context.Inventories.Add(iv);
                    }
                    context.SaveChanges();
                }

                int[] projectInventoryIDs = context.Inventories.Select(i => i.ID).ToArray();
                int[] projectIds = context.Projects.Select(p => p.ID).ToArray();

                Random random = new Random();

                if (!context.ProjectInventories.Any())
                {
                    int inventorycount = projectInventoryIDs.Count();
                    foreach (int i in projectIds)
                    {
                        int howMany = random.Next(1, 8);
                        howMany = (howMany > inventorycount) ? inventorycount : howMany;
                        for (int j = 1; j <= howMany; j++)
                        {
                            ProjectInventory pi = new ProjectInventory()
                            {
                                ProjectID = i,
                                InventoryID = projectInventoryIDs[random.Next(inventorycount)]
                            };
                            context.ProjectInventories.Add(pi);
                        }
                    }
                    context.SaveChanges();
                }

                if (!context.Inventories.Any())
                {
                    context.Inventories.AddRange(
                        new Inventory
                        {
                            Name = "Daffodil",
                            Code = "DFDL",
                            UnitCost = 6,
                            CategoryID = context.Categories.FirstOrDefault(c => c.Name == "Plants").ID

                        },
                        new Inventory
                        {
                            Name = "Rose",
                            Code = "ROSE",
                            UnitCost = 8,
                            CategoryID = context.Categories.FirstOrDefault(c => c.Name == "Plants").ID
                        },
                        new Inventory
                        {
                            Name = "Golden Dewdrop",
                            Code = "GLDD",
                            UnitCost = 20,
                            CategoryID = context.Categories.FirstOrDefault(c => c.Name == "Plants").ID
                        },

                        new Inventory
                        {
                            Name = "China Rose",
                            Code = "CHRS",
                            UnitCost = 25,
                            CategoryID = context.Categories.FirstOrDefault(c => c.Name == "Plants").ID
                        },

                        new Inventory
                        {
                            Name = "Tulip",
                            Code = "TLIP",
                            UnitCost = 10,
                            CategoryID = context.Categories.FirstOrDefault(c => c.Name == "Plants").ID
                        },

                        new Inventory
                        {
                            Name = "Sunflower",
                            Code = "SNFL",
                            UnitCost = 15,
                            CategoryID = context.Categories.FirstOrDefault(c => c.Name == "Plants").ID
                        },

                        new Inventory
                        {
                            Name = "Compost",
                            Code = "CPST",
                            UnitCost = 20,
                            CategoryID = context.Categories.FirstOrDefault(c => c.Name == "Materials").ID
                        },
                        new Inventory
                        {
                            Name = "Fertilizer",
                            Code = "FRTZ",
                            UnitCost = 30,
                            CategoryID = context.Categories.FirstOrDefault(c => c.Name == "Materials").ID
                        },
                        new Inventory
                        {
                            Name = "Mulch",
                            Code = "MLCH",
                            UnitCost = 15,
                            CategoryID = context.Categories.FirstOrDefault(c => c.Name == "Materials").ID
                        },
                        new Inventory

                        {
                            Name = "Rake",
                            Code = "RAKE",
                            UnitCost = 20,
                            CategoryID = context.Categories.FirstOrDefault(c => c.Name == "Tools").ID
                        },
                        new Inventory
                        {
                            Name = "Hoe",
                            Code = "HOE",
                            UnitCost = 16,
                            CategoryID = context.Categories.FirstOrDefault(c => c.Name == "Tools").ID

                        },
                        new Inventory
                        {
                            Name = "Shovel",
                            Code = "SHVL",
                            UnitCost = 25,
                            CategoryID = context.Categories.FirstOrDefault(c => c.Name == "Tools").ID
                        },
                        new Inventory
                        {
                            Name = "Wheelbarrow",
                            Code = "WHBR",
                            UnitCost = 30,
                            CategoryID = context.Categories.FirstOrDefault(c => c.Name == "Tools").ID
                        }
                        );
                    context.SaveChanges();



                }
                if (!context.ProjectInventories.Any())
                {
                    context.ProjectInventories.AddRange(

                            new ProjectInventory
                            {
                                ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Seaway Mall").ID,
                                InventoryID = context.Inventories.FirstOrDefault(i => i.Code == "DFDL").ID

                            },
                            new ProjectInventory
                            {
                                ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Seaway Mall").ID,
                                InventoryID = context.Inventories.FirstOrDefault(i => i.Code == "SNFL").ID

                            },
                            new ProjectInventory
                            {
                                ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Seaway Mall").ID,
                                InventoryID = context.Inventories.FirstOrDefault(i => i.Code == "SHVL").ID

                            },
                            new ProjectInventory
                            {
                                ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Seaway Mall").ID,
                                InventoryID = context.Inventories.FirstOrDefault(i => i.Code == "WHBR").ID

                            },
                            new ProjectInventory
                            {
                                ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Seaway Mall").ID,
                                InventoryID = context.Inventories.FirstOrDefault(i => i.Code == "MLCH").ID

                            },
                            new ProjectInventory
                            {
                                ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Seaway Mall").ID,
                                InventoryID = context.Inventories.FirstOrDefault(i => i.Code == "FRTZ").ID

                            },
                            new ProjectInventory
                            {
                                ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Vaughn Mills").ID,
                                InventoryID = context.Inventories.FirstOrDefault(i => i.Code == "CHRS").ID

                            },
                            new ProjectInventory
                            {
                                ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Vaughn Mills").ID,
                                InventoryID = context.Inventories.FirstOrDefault(i => i.Code == "ROSE").ID

                            },
                            new ProjectInventory
                            {
                                ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Vaughn Mills").ID,
                                InventoryID = context.Inventories.FirstOrDefault(i => i.Code == "HOE").ID

                            },
                            new ProjectInventory
                            {
                                ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Vaughn Mills").ID,
                                InventoryID = context.Inventories.FirstOrDefault(i => i.Code == "RAKE").ID

                            },
                            new ProjectInventory
                            {
                                ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Vaughn Mills").ID,
                                InventoryID = context.Inventories.FirstOrDefault(i => i.Code == "CPST").ID

                            }
                        );
                    context.SaveChanges();
                }

            }

        }
    }
}
    


    




