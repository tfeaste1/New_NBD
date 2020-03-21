using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NBD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NBD.Data;

namespace NBD.Data
{
    public static class NBDSeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new NBDContext(
                serviceProvider.GetRequiredService<DbContextOptions<NBDContext>>()))
            {
                if (!context.Cities.Any())
                {
                    context.Cities.AddRange(
                     new City
                     {
                         Name = "St. Catharines"
                     },
                     new City
                     {
                         Name = "Welland"
                     },
                     new City
                     {
                         Name = "Niagara Falls"
                     },
                     new City
                     {
                         Name = "Fort Erie"
                     },
                     new City
                     {
                         Name = "Niagara-On-The-Lake"
                     },
                     new City
                     {
                         Name = "Grimsby"
                     },
                     new City
                     {
                         Name = "Fonthill"
                     },
                     new City
                     {
                         Name = "Toronto"
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
                            Position = "Director",
                            PhoneNumber = 2896489638,
                            Email = "cbrown@outlook.com",
                            Address = "123 Plum Road",
                            CityID = context.Cities.FirstOrDefault(c => c.Name == "St. Catharines").ID,
                            Province = "Ontario",
                            PostalCode = "L2S1G6"

                        },

                     new Client
                     {
                         FirstName = "Brad",
                         LastName = "Ferguson",
                         CompanyName = "BF Corporation",
                         Position = "Chief Executive Officer",
                         PhoneNumber = 9056487592,
                         Email = "bferg@gmail.com",
                         Address = "24 Graystone Avenue",
                         CityID = context.Cities.FirstOrDefault(c => c.Name == "Welland").ID,
                         Province = "Ontario",
                         PostalCode = "L3C4R6"
                     },

                     new Client
                     {
                         FirstName = "Robin",
                         LastName = "Jones",
                         CompanyName = "Jones Solutions Inc.",
                         Position = "Chief Executive Officer",
                         PhoneNumber = 6475869324,
                         Email = "rjones@yahoo.ca",
                         Address = "3 Beacon Road",
                         CityID = context.Cities.FirstOrDefault(c => c.Name == "Toronto").ID,
                         Province = "Ontario",
                         PostalCode = "M2J5H6"
                     });
                    context.SaveChanges();

                    if (!context.Materials.Any())
                    {
                        context.Materials.AddRange(
                            new Material
                            {
                                Description = "Lacco Australasica",
                                Type = "Plant"
                            },
                            new Material
                            {
                                Description = "Arenga Pinnata",
                                Type = "Plant"
                            },
                            new Material
                            {
                                Description = "Chamaedorea",
                                Type = "Plant"
                            },
                            new Material
                            {
                                Description = "Ceratozamia Molongo",
                                Type = "Plant"
                            },
                            new Material
                            {
                                Description = "Arecastum Coco",
                                Type = "Plant"
                            },
                            new Material
                            {
                                Description = "Caryota Mitis",
                                Type = "Plant"
                            },
                            new Material
                            {
                                Description = "Green Ti",
                                Type = "Plant"
                            },
                            new Material
                            {
                                Description = "Ficus Green Gem",
                                Type = "Plant"
                            },
                            new Material
                            {
                                Description = "Marginata",
                                Type = "Plant",
                            },
                            new Material
                            {
                                Description = "T/C Pot",
                                Type = "Pottery"
                            },
                            new Material
                            {
                                Description = "Granite Pot",
                                Type = "Pottery"
                            },
                            new Material
                            {
                                Description = "T/C Figurine Swan",
                                Type = "Pottery"
                            },
                            new Material
                            {
                                Description = "Marble Bird Bath",
                                Type = "Pottery"
                            },
                            new Material
                            {
                                Description = "Granite Fountain",
                                Type = "Pottery"
                            },
                            new Material
                            {
                                Description = "Decorative Cedar Bark",
                                Type = "Materials"
                            },
                            new Material
                            {
                                Description = "Crushed Granite",
                                Type = "Materials"
                            },
                            new Material
                            {
                                Description = "Pea Gravel",
                                Type = "Materials"
                            },
                            new Material
                            {
                                Description = "Gravel",
                                Type = "Materials"
                            },
                            new Material
                            {
                                Description = "Top Soil",
                                Type = "Materials"
                            },
                            new Material
                            {
                                Description = "Patio Block-Gray",
                                Type = "Materials"
                            },
                            new Material
                            {
                                Description = "Patio Block-Red",
                                Type = "Materials"
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
                                ProjSite = "Parking Lot",
                                ProjBidDate = DateTime.Parse("2020-01-30"),
                                EstStartDate = DateTime.Parse("2020-06-10"),
                                EstEndDate = DateTime.Parse("2020-06-18"),
                                StartDate = DateTime.Parse("2020-06-10"),
                                EndDate = DateTime.Parse("2020-06-18"),
                                ActAmount = 7650,
                                EstAmount = 8000,
                                ClientApproval = true,
                                AdminApproval = true,
                                ProjIsFlagged = true,
                                ProjCurrentPhase = "Executing",
                                ClientID = context.Clients.FirstOrDefault(c => c.FirstName == "Cheryl" && c.LastName == "Brown").ID,

                            },

                           new Project
                           {
                               Name = "Vaughn Mills",
                               ProjSite = "Parking Lot",
                               ProjBidDate = DateTime.Parse("2020-03-20"),
                               EstStartDate = DateTime.Parse("2020-03-25"),
                               EstEndDate = DateTime.Parse("2020-03-30"),
                               EstAmount = 8000,
                               ClientApproval = false,
                               AdminApproval = false,
                               ProjIsFlagged = false,
                               ProjCurrentPhase = "Planning",
                               ClientID = context.Clients.FirstOrDefault(c => c.FirstName == "Robin" && c.LastName == "Jones").ID,



                           });

                        context.SaveChanges();


                    }
                    if (!context.Departments.Any())
                    {
                        context.Departments.AddRange(
                            new Department
                            {
                                Description = "Production Worker",
                                Price = 30,
                                Cost = 18
                            },
                            new Department
                            {
                                Description = "Designer",
                                Price = 65,
                                Cost = 40
                            },
                            new Department
                            {
                                Description = "Equipment Operator",
                                Price = 65,
                                Cost = 45
                            },
                            new Department
                            {
                                Description = "Botanist",
                                Price = 75,
                                Cost = 50
                            },
                            new Department
                            {
                                Description = "Design Manager",
                                Price = 100
                            },
                            new Department
                            {
                                Description = "Production Manager",
                                Price = 150
                            },
                            new Department
                            {
                                Description = "Sales Associate",
                                Price = 85
                            },
                            new Department
                            {
                                Description = "Sales and Finance Manager",
                                Price = 75
                            });
                        context.SaveChanges();
                    }
                    if (!context.Tools.Any())
                    {
                        context.Tools.AddRange(
                            new Tool
                            {
                                Description = "Contouring Rakes"
                            },
                            new Tool
                            {
                                Description = "Spades"
                            },
                            new Tool
                            {
                                Description = "Landscaping Rakes"
                            });
                        context.SaveChanges();

                    }
                    if (!context.Employees.Any())
                    {
                        context.Employees.AddRange(
                            new Employee
                            {
                                FirstName = "Cheryl",
                                LastName = "Poy",
                                Email = "breinhardt@nbd.com",
                                PhoneNumber = 4087753652,
                                DepartmentID = 4
                            },
                            new Employee
                            {
                                FirstName = "Keri",
                                LastName = "Yamaguchi",
                                Email = "rbradley@nbd.com",
                                PhoneNumber = 4087753650,
                                DepartmentID = 5
                            },
                            new Employee
                            {
                                FirstName = "Tamara",
                                LastName = "Bakken",
                                Email = "tbakken@nbd.com",
                                PhoneNumber = 4087753642,
                                DepartmentID = 2
                            },
                            new Employee
                            {
                                FirstName = "Bob",
                                LastName = "Reinhardt",
                                Email = "psaunders@nbd.com",
                                PhoneNumber = 4087753640,
                                DepartmentID = 7
                            },
                            new Employee
                            {
                                FirstName = "Sue",
                                LastName = "Kaufman",
                                Email = "mgoce@nbd.com",
                                PhoneNumber = 4087753692,
                                DepartmentID = 6
                            },
                           new Employee
                           {
                               FirstName = "Monica",
                               LastName = "Goce",
                               Email = "bswenson@nbd.com",
                               PhoneNumber = 4087753689,
                               DepartmentID = 1
                           },
                           new Employee
                           {
                               FirstName = "Bert",
                               LastName = "Swenson",
                               Email = "bertwenson@nbd.com",
                               PhoneNumber = 4087753600,
                               DepartmentID = 1
                           },
                           new Employee
                           {
                               FirstName = "Stan",
                               LastName = "Fenton",
                               Email = "stanwenson@nbd.com",
                               PhoneNumber = 4087753601,
                               DepartmentID = 8
                           },
                           new Employee
                           {
                               FirstName = "Joe",
                               LastName = "Smith",
                               Email = "Joeenson@nbd.com",
                               PhoneNumber = 4087753622,
                               DepartmentID = 3
                           },
                           new Employee
                           {
                               FirstName = "Jerry",
                               LastName = "Jones",
                               Email = "Jerryson@nbd.com",
                               PhoneNumber = 4087753677,
                               DepartmentID = 1
                           });
                        context.SaveChanges();

                    }
                    if (!context.Tasks.Any())
                    {
                        context.Tasks.AddRange(
                            new Models.Task
                            {
                                Description = "Bid Process"
                            },
                            new Models.Task
                            {
                                Description = "Complete final blueprints"
                            },
                            new Models.Task
                            {
                                Description = "Oversee installation of fountains and pots"
                            },
                            new Models.Task
                            {
                                Description = "Inspect contouring"
                            },
                            new Models.Task
                            {
                                Description = "Inspect finished site"
                            },
                            new Models.Task
                            {
                                Description = "Contour surface"
                            },
                            new Models.Task
                            {
                                Description = "Install large plants"
                            },
                            new Models.Task
                            {
                                Description = "Install small plants and bark"
                            },
                            new Models.Task
                            {
                                Description = "Remove existing structure"
                            },
                            new Models.Task
                            {
                                Description = "Situate fountains and pots"
                            },
                            new Models.Task
                            {
                                Description = "Shape surface"
                            });
                        context.SaveChanges();


                    }
                    if (!context.Teams.Any())
                    {
                        context.Teams.AddRange(
                             new Team
                             {
                                 ID = 1,
                                 TeamName = "Team 1",
                                 ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Seaway Mall").ID,
                                 EmployeeID = 1,
                                 Phase = "D"
                             },
                            new Team
                            {
                                ID = 3,
                                TeamName = "I am team 2",
                                ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Seaway Mall").ID,
                                EmployeeID = 2,
                                Phase = "D"
                            },
                            new Team
                            {
                                ID = 3,
                                TeamName = "So I am team 3",
                                ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Seaway Mall").ID,
                                EmployeeID = 3,
                                Phase = "P"
                            },
                            new Team
                            {
                                ID = 4,
                                TeamName = "I dont want be 4",
                                ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Seaway Mall").ID,
                                EmployeeID = 4,
                                Phase = "P"
                            },
                            new Team
                            {
                                ID = 2,
                                TeamName = "5",
                                ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Seaway Mall").ID,
                                EmployeeID = 5,
                                Phase = "P"
                            },
                            new Team
                            {
                                ID = 2,
                                TeamName = "why 5 is such short",
                                ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Seaway Mall").ID,
                                EmployeeID = 6,
                                Phase = "P"
                            },
                            new Team
                            {
                                ID = 2,
                                ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Seaway Mall").ID,
                                Phase = "P"
                            },
                            new Team
                            {
                                ID = 2,
                                TeamName = "Finally",
                                ProjectID = context.Projects.FirstOrDefault(p => p.Name == "Seaway Mall").ID,
                                EmployeeID = 8,
                                Phase = "P"
                            }
                            );
                        context.SaveChanges();
                    }
                    if (!context.Inventories.Any())
                    {
                        context.Inventories.AddRange(
                            new Inventory
                            {
                                MaterialID = 1,
                                AvgNet = 450,
                                List = 749,
                                SizeAmount = 15,
                                SizeUnit = "gal",
                                Quantity = 3
                            },
                            new Inventory
                            {
                                MaterialID = 2,
                                AvgNet = 310,
                                List = 516,
                                SizeAmount = 15,
                                SizeUnit = "gal",
                                Quantity = 4
                            },
                            new Inventory
                            {
                                MaterialID = 3,
                                AvgNet = 300,
                                List = 499,
                                SizeAmount = 15,
                                SizeUnit = "gal",
                                Quantity = 0
                            },
                            new Inventory
                            {
                                MaterialID = 4,
                                AvgNet = 240,
                                List = 400,
                                SizeAmount = 14,
                                SizeUnit = "in",
                                Quantity = 4
                            },
                            new Inventory
                            {
                                MaterialID = 5,
                                AvgNet = 275,
                                List = 458,
                                SizeAmount = 15,
                                SizeUnit = "gal",
                                Quantity = 11
                            },
                            new Inventory
                            {
                                MaterialID = 6,
                                AvgNet = 140,
                                List = 233,
                                SizeAmount = 7,
                                SizeUnit = "gal",
                                Quantity = 0
                            },
                            new Inventory
                            {
                                MaterialID = 7,
                                AvgNet = 92,
                                List = 154,
                                SizeAmount = 5,
                                SizeUnit = "gal",
                                Quantity = 11
                            },
                            new Inventory
                            {
                                MaterialID = 7,
                                AvgNet = 140,
                                List = 234,
                                SizeAmount = 7,
                                SizeUnit = "gal",
                                Quantity = 8
                            },
                            new Inventory
                            {
                                MaterialID = 8,
                                AvgNet = 90,
                                List = 150,
                                SizeAmount = 14,
                                SizeUnit = "in",
                                Quantity = 7
                            },
                            new Inventory
                            {
                                MaterialID = 8,
                                AvgNet = 240,
                                List = 400,
                                SizeAmount = 17,
                                SizeUnit = "in",
                                Quantity = 6
                            },
                            new Inventory
                            {
                                MaterialID = 9,
                                AvgNet = 45,
                                List = 75,
                                SizeAmount = 2,
                                SizeUnit = "gal",
                                Quantity = 16
                            },
                            new Inventory
                            {
                                MaterialID = 10,
                                AvgNet = 53,
                                List = 110,
                                SizeAmount = 50,
                                SizeUnit = "gal",
                                Quantity = 5
                            },
                            new Inventory
                            {
                                MaterialID = 11,
                                AvgNet = 110,
                                List = 195,
                                SizeAmount = 50,
                                SizeUnit = "gal",
                                Quantity = 5
                            },
                            new Inventory
                            {
                                MaterialID = 12,
                                AvgNet = 25,
                                List = 45,
                                Quantity = 3
                            },
                            new Inventory
                            {
                                MaterialID = 12,
                                AvgNet = 128,
                                List = 250,
                                SizeAmount = 30,
                                SizeUnit = "in",
                                Quantity = 2
                            },
                            new Inventory
                            {
                                MaterialID = 14,
                                AvgNet = 457,
                                List = 750,
                                SizeAmount = 48,
                                SizeUnit = "in",
                                Quantity = 1
                            },
                            new Inventory
                            {
                                MaterialID = 15,
                                AvgNet = 7,
                                List = 15,
                                SizeAmount = 5,
                                SizeUnit = "cu ft",
                                Quantity = 53
                            },
                            new Inventory
                            {
                                MaterialID = 16,
                                AvgNet = 7,
                                List = 14,
                                SizeUnit = "yard",
                                Quantity = 12
                            },
                             new Inventory
                             {
                                 MaterialID = 17,
                                 AvgNet = 8,
                                 List = 20,
                                 SizeUnit = "yard",
                                 Quantity = 7
                             },
                              new Inventory
                              {
                                  MaterialID = 18,
                                  AvgNet = 5,
                                  List = 12,
                                  SizeUnit = "yard",
                                  Quantity = 18
                              },
                               new Inventory
                               {
                                   MaterialID = 19,
                                   AvgNet = 12,
                                   List = 20,
                                   SizeUnit = "yard",
                                   Quantity = 10
                               },
                                new Inventory
                                {
                                    MaterialID = 20,
                                    AvgNet = 56,
                                    List = 84,
                                    SizeUnit = "yard",
                                    Quantity = 94
                                }
                            );
                        context.SaveChanges();
                    }
                    if (!context.LabourRequirements.Any())
                    {
                        context.LabourRequirements.AddRange(
                            new LabourRequirement
                            {
                                TeamID = 1,
                                TaskID = 1,
                                LabourSummaryID = 2,
                                EstHours = 12,
                            },
                            new LabourRequirement
                            {
                                TeamID = 1,
                                TaskID = 2,
                                LabourSummaryID = 1,
                                EstDate = DateTime.Parse("2020-06-10"),
                                EstHours = 5,

                            },
                             new LabourRequirement
                             {
                                 TeamID = 1,
                                 TaskID = 3,
                                 LabourSummaryID = 10,
                                 EstDate = DateTime.Parse("2020-06-15"),
                                 EstHours = 3,

                             },
                              new LabourRequirement
                              {
                                  TeamID = 1,
                                  TaskID = 4,
                                  LabourSummaryID = 11,
                                  EstDate = DateTime.Parse("2020-06-16"),
                                  EstHours = 1,

                              },
                               new LabourRequirement
                               {
                                   TeamID = 1,
                                   TaskID = 5,
                                   LabourSummaryID = 12,
                                   EstDate = DateTime.Parse("2020-06-18"),
                                   EstHours = 1,

                               },
                                new LabourRequirement
                                {
                                    TeamID = 4,
                                    TaskID = 6,
                                    LabourSummaryID = 13,
                                    EstDate = DateTime.Parse("2020-06-15"),
                                    EstHours = 3,

                                },
                                 new LabourRequirement
                                 {
                                     TeamID = 4,
                                     LabourSummaryID = 1,
                                     TaskID = 7,
                                     EstDate = DateTime.Parse("2020-06-16"),
                                     EstHours = 4,

                                 },
                                  new LabourRequirement
                                  {
                                      TeamID = 4,
                                      LabourSummaryID = 2,
                                      TaskID = 8,
                                      EstDate = DateTime.Parse("2020-06-17"),
                                      EstHours = 8,

                                  },
                                  new LabourRequirement
                                  {
                                      TeamID = 5,
                                      LabourSummaryID= 3,
                                      TaskID = 6,
                                      EstDate = DateTime.Parse("2020-06-15"),
                                      EstHours = 3,

                                  },
                                  new LabourRequirement
                                  {
                                      TeamID = 5,
                                      TaskID = 7,
                                      LabourSummaryID =4,
                                      EstDate = DateTime.Parse("2020-06-16"),
                                      EstHours = 4,

                                  },
                                  new LabourRequirement
                                  {
                                      TeamID = 5,
                                      LabourSummaryID =5,
                                      TaskID = 8,
                                      EstDate = DateTime.Parse("2020-06-17"),
                                      EstHours = 8,

                                  },
                                  new LabourRequirement
                                  {
                                      TeamID = 6,
                                      LabourSummaryID = 6,
                                      TaskID = 10,
                                      EstDate = DateTime.Parse("2020-06-15"),
                                      EstHours = 4,

                                  },
                                  new LabourRequirement
                                  {
                                      TeamID = 7,
                                      TaskID = 9,
                                      LabourSummaryID = 7,
                                      EstDate = DateTime.Parse("2020-06-14"),
                                      EstHours = 6,

                                  }
                            );
                        context.SaveChanges();
                    }
                    if (!context.MaterialRequirements.Any())
                    {
                        context.MaterialRequirements.AddRange(
                            new MaterialRequirement
                            {
                                InventoryID = 1,

                                DeliveryDate = DateTime.Parse("2020-06-16"),
                                DeliveryTime = DateTime.Parse("08:00:00"),
                                InstallDate = DateTime.Parse("2020-06-16"),
                                InstallTime = DateTime.Parse("00:00:00"),
                                EstQuantity = 3
                            },
                            new MaterialRequirement
                            {
                                InventoryID = 5,

                                DeliveryDate = DateTime.Parse("2020-06-17"),
                                DeliveryTime = DateTime.Parse("08:00:00"),
                                InstallDate = DateTime.Parse("2020-06-17"),
                                InstallTime = DateTime.Parse("00:00:00"),
                                EstQuantity = 5
                            },
                            new MaterialRequirement
                            {
                                InventoryID = 9,

                                DeliveryDate = DateTime.Parse("2020-06-17"),
                                DeliveryTime = DateTime.Parse("08:00:00"),
                                InstallDate = DateTime.Parse("2020-06-17"),
                                InstallTime = DateTime.Parse("00:00:00"),
                                EstQuantity = 7
                            },
                            new MaterialRequirement
                            {
                                InventoryID = 13,

                                DeliveryDate = DateTime.Parse("2020-06-15"),
                                DeliveryTime = DateTime.Parse("08:00:00"),
                                InstallDate = DateTime.Parse("2020-06-15"),
                                InstallTime = DateTime.Parse("00:00:00"),
                                EstQuantity = 1
                            },
                            new MaterialRequirement
                            {
                                InventoryID = 11,

                                DeliveryDate = DateTime.Parse("2020-06-15"),
                                DeliveryTime = DateTime.Parse("08:00:00"),
                                InstallDate = DateTime.Parse("2020-06-15"),
                                InstallTime = DateTime.Parse("00:00:00"),
                                EstQuantity = 3
                            },
                            new MaterialRequirement
                            {
                                InventoryID = 14,

                                DeliveryDate = DateTime.Parse("2020-06-17"),
                                DeliveryTime = DateTime.Parse("08:00:00"),
                                InstallDate = DateTime.Parse("2020-06-17"),
                                InstallTime = DateTime.Parse("00:00:00"),
                                EstQuantity = 10
                            },
                            new MaterialRequirement
                            {
                                InventoryID = 18,

                                DeliveryDate = DateTime.Parse("2020-06-15"),
                                DeliveryTime = DateTime.Parse("13:00:00"),
                                InstallDate = DateTime.Parse("2020-06-15"),
                                InstallTime = DateTime.Parse("00:00:00"),
                                EstQuantity = 1
                            });
                        context.SaveChanges();

                    }
                    if (!context.ProductionTools.Any())
                    {
                        context.ProductionTools.AddRange(
                            new ProductionTool
                            {
                                ProjectID = 1,
                                ToolID = 1,
                                Quantity = 2,
                                EarliestDelivery = DateTime.Parse("2020-06-15")
                            },
                            new ProductionTool
                            {
                                ProjectID = 1,
                                ToolID = 2,
                                Quantity = 2,
                                EarliestDelivery = DateTime.Parse("2020-06-16"),
                                LatestDelivery = DateTime.Parse("2020-06-17")
                            },
                           new ProductionTool
                           {
                               ProjectID = 1,
                               ToolID = 3,
                               Quantity = 2,
                               EarliestDelivery = DateTime.Parse("2020-06-16"),
                               LatestDelivery = DateTime.Parse("2020-06-17")
                           }
                            );
                        context.SaveChanges();
                    }
                    if (!context.LabourSummaries.Any())
                    {
                        context.LabourSummaries.AddRange(
                            new LabourSummary
                            {
                                ProjectID = 1,
                                DepartmentID = 1,
                                Hours = 30
                            },
                             new LabourSummary
                             {
                                 ProjectID = 1,
                                 DepartmentID = 2,
                                 Hours = 10
                             },
                              new LabourSummary
                              {
                                  ProjectID = 1,
                                  DepartmentID = 3,
                                  Hours = 10
                              }
                            );
                        context.SaveChanges();
                    }
                    if (!context.ProductionPlans.Any())
                    {
                        context.ProductionPlans.AddRange(
                            new ProductionPlan
                            {
                                ProjectID = 1,
                                TeamID = 1,
                               
                            }
                            ) ;
                        context.SaveChanges();
                    }
                    if (!context.ProdPlanLabours.Any())
                    {
                        context.ProdPlanLabours.AddRange(
                            new ProdPlanLabour
                            {
                                ProdPlanID = 1,
                                LabourReqID = 1
                            },
                            new ProdPlanLabour
                            {
                                ProdPlanID = 1,
                                LabourReqID = 3
                            },
                            new ProdPlanLabour
                            {
                                ProdPlanID = 1,
                                LabourReqID = 5
                            }

                            );
                        context.SaveChanges();
                    }
                    if (!context.ProdPlanMaterials.Any())
                    {
                        context.ProdPlanMaterials.AddRange(
                            new ProdPlanMaterial
                            {
                                ProdPlanID = 1,
                                MaterialReqID = 1
                            },
                            new ProdPlanMaterial
                            {
                                ProdPlanID = 1,
                                MaterialReqID = 3
                            },
                            new ProdPlanMaterial
                            {
                                ProdPlanID = 1,
                                MaterialReqID = 5
                            }

                            );
                        context.SaveChanges();
                    }
                    if (!context.ProjectLabours.Any())
                    {
                        context.ProjectLabours.AddRange(
                            new ProjectLabour
                            {
                                ProjectID = 1,
                                LabourReqID = 1
                            },
                            new ProjectLabour
                            {
                                ProjectID = 1,
                                LabourReqID = 3
                            },
                            new ProjectLabour
                            {
                                ProjectID = 1,
                                LabourReqID = 5
                            }

                            );
                        context.SaveChanges();
                    }
                    if (!context.ProjectMaterials.Any())
                    {
                        context.ProjectMaterials.AddRange(
                            new ProjectMaterial
                            {
                                ProjectID = 1,
                                MaterialReqID = 1
                            },
                            new ProjectMaterial
                            {
                                ProjectID = 1,
                                MaterialReqID = 3
                            },
                            new ProjectMaterial
                            {
                                ProjectID = 1,
                                MaterialReqID = 5
                            }

                            );
                        context.SaveChanges();
                    }


                }
            }
        }
    }
}

