using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NBD.Data.NBDMigrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "MO");

            migrationBuilder.CreateTable(
                name: "Cities",
                schema: "MO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                schema: "MO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: true),
                    Cost = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                schema: "MO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                schema: "MO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    StdTimeAmnt = table.Column<int>(nullable: false),
                    stdTimeUnit = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tools",
                schema: "MO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tools", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                schema: "MO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    CompanyName = table.Column<string>(maxLength: 50, nullable: false),
                    Position = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<long>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    CityID = table.Column<int>(nullable: false),
                    Province = table.Column<string>(nullable: false),
                    PostalCode = table.Column<string>(maxLength: 6, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Clients_Cities_CityID",
                        column: x => x.CityID,
                        principalSchema: "MO",
                        principalTable: "Cities",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "MO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<long>(nullable: false),
                    DepartmentID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalSchema: "MO",
                        principalTable: "Departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                schema: "MO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AvgNet = table.Column<double>(nullable: false),
                    List = table.Column<double>(nullable: false),
                    SizeAmount = table.Column<int>(nullable: false),
                    SizeUnit = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    MaterialID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventories_Materials_MaterialID",
                        column: x => x.MaterialID,
                        principalSchema: "MO",
                        principalTable: "Materials",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                schema: "MO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 256, nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedBy = table.Column<string>(maxLength: 256, nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    ProjSite = table.Column<string>(nullable: true),
                    ProjBidDate = table.Column<DateTime>(nullable: true),
                    EstStartDate = table.Column<DateTime>(nullable: false),
                    EstEndDate = table.Column<DateTime>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    ActAmount = table.Column<float>(nullable: true),
                    EstAmount = table.Column<float>(nullable: false),
                    ClientApproval = table.Column<bool>(nullable: false),
                    AdminApproval = table.Column<bool>(nullable: false),
                    ProjCurrentPhase = table.Column<string>(nullable: true),
                    ClientID = table.Column<int>(nullable: false),
                    ProjIsFlagged = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Projects_Clients_ClientID",
                        column: x => x.ClientID,
                        principalSchema: "MO",
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LabourSummaries",
                schema: "MO",
                columns: table => new
                {
                    ProjectID = table.Column<int>(nullable: false),
                    DepartmentID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    Hours = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabourSummaries", x => new { x.ProjectID, x.DepartmentID });
                    table.ForeignKey(
                        name: "FK_LabourSummaries_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalSchema: "MO",
                        principalTable: "Departments",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LabourSummaries_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalSchema: "MO",
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialRequirements",
                schema: "MO",
                columns: table => new
                {
                    ProjectID = table.Column<int>(nullable: false),
                    InventoryID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    DeliveryDate = table.Column<DateTime>(nullable: true),
                    DeliveryTime = table.Column<DateTime>(nullable: true),
                    InstallDate = table.Column<DateTime>(nullable: true),
                    InstallTime = table.Column<DateTime>(nullable: true),
                    EstQuantity = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialRequirements", x => new { x.InventoryID, x.ProjectID });
                    table.ForeignKey(
                        name: "FK_MaterialRequirements_Inventories_InventoryID",
                        column: x => x.InventoryID,
                        principalSchema: "MO",
                        principalTable: "Inventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialRequirements_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalSchema: "MO",
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionTools",
                schema: "MO",
                columns: table => new
                {
                    ProjectID = table.Column<int>(nullable: false),
                    ToolID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    EarliestDelivery = table.Column<DateTime>(nullable: true),
                    LatestDelivery = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionTools", x => new { x.ProjectID, x.ToolID });
                    table.ForeignKey(
                        name: "FK_ProductionTools_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalSchema: "MO",
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductionTools_Tools_ToolID",
                        column: x => x.ToolID,
                        principalSchema: "MO",
                        principalTable: "Tools",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                schema: "MO",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false),
                    ProjectID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    Phase = table.Column<string>(nullable: true),
                    TeamName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => new { x.ProjectID, x.EmployeeID });
                    table.ForeignKey(
                        name: "FK_Teams_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalSchema: "MO",
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teams_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalSchema: "MO",
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LabourRequirements",
                schema: "MO",
                columns: table => new
                {
                    TeamID = table.Column<int>(nullable: false),
                    TaskID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    EstDate = table.Column<DateTime>(nullable: true),
                    EstHours = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: true),
                    Hours = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    TeamProjectID = table.Column<int>(nullable: true),
                    TeamEmployeeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabourRequirements", x => new { x.TeamID, x.TaskID });
                    table.ForeignKey(
                        name: "FK_LabourRequirements_Tasks_TaskID",
                        column: x => x.TaskID,
                        principalSchema: "MO",
                        principalTable: "Tasks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LabourRequirements_Teams_TeamProjectID_TeamEmployeeID",
                        columns: x => new { x.TeamProjectID, x.TeamEmployeeID },
                        principalSchema: "MO",
                        principalTable: "Teams",
                        principalColumns: new[] { "ProjectID", "EmployeeID" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CityID",
                schema: "MO",
                table: "Clients",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_Email",
                schema: "MO",
                table: "Clients",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentID",
                schema: "MO",
                table: "Employees",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                schema: "MO",
                table: "Employees",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_MaterialID",
                schema: "MO",
                table: "Inventories",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_LabourRequirements_TaskID",
                schema: "MO",
                table: "LabourRequirements",
                column: "TaskID");

            migrationBuilder.CreateIndex(
                name: "IX_LabourRequirements_TeamProjectID_TeamEmployeeID",
                schema: "MO",
                table: "LabourRequirements",
                columns: new[] { "TeamProjectID", "TeamEmployeeID" });

            migrationBuilder.CreateIndex(
                name: "IX_LabourSummaries_DepartmentID",
                schema: "MO",
                table: "LabourSummaries",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialRequirements_ProjectID",
                schema: "MO",
                table: "MaterialRequirements",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionTools_ToolID",
                schema: "MO",
                table: "ProductionTools",
                column: "ToolID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ClientID",
                schema: "MO",
                table: "Projects",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_EmployeeID",
                schema: "MO",
                table: "Teams",
                column: "EmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabourRequirements",
                schema: "MO");

            migrationBuilder.DropTable(
                name: "LabourSummaries",
                schema: "MO");

            migrationBuilder.DropTable(
                name: "MaterialRequirements",
                schema: "MO");

            migrationBuilder.DropTable(
                name: "ProductionTools",
                schema: "MO");

            migrationBuilder.DropTable(
                name: "Tasks",
                schema: "MO");

            migrationBuilder.DropTable(
                name: "Teams",
                schema: "MO");

            migrationBuilder.DropTable(
                name: "Inventories",
                schema: "MO");

            migrationBuilder.DropTable(
                name: "Tools",
                schema: "MO");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "MO");

            migrationBuilder.DropTable(
                name: "Projects",
                schema: "MO");

            migrationBuilder.DropTable(
                name: "Materials",
                schema: "MO");

            migrationBuilder.DropTable(
                name: "Departments",
                schema: "MO");

            migrationBuilder.DropTable(
                name: "Clients",
                schema: "MO");

            migrationBuilder.DropTable(
                name: "Cities",
                schema: "MO");
        }
    }
}
