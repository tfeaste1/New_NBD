using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NBD.Data.NBDMigrations
{
    public partial class aaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkerReports",
                schema: "MO");

            migrationBuilder.CreateTable(
                name: "WReports",
                schema: "MO",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false),
                    TaskID = table.Column<int>(nullable: false),
                    ProjectID = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: true),
                    Hour = table.Column<int>(nullable: false),
                    Cost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WReports", x => new { x.ProjectID, x.TaskID, x.EmployeeID });
                    table.ForeignKey(
                        name: "FK_WReports_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalSchema: "MO",
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WReports_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalSchema: "MO",
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WReports_Tasks_TaskID",
                        column: x => x.TaskID,
                        principalSchema: "MO",
                        principalTable: "Tasks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WReports_EmployeeID",
                schema: "MO",
                table: "WReports",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_WReports_TaskID",
                schema: "MO",
                table: "WReports",
                column: "TaskID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WReports",
                schema: "MO");

            migrationBuilder.CreateTable(
                name: "WorkerReports",
                schema: "MO",
                columns: table => new
                {
                    ProjectID = table.Column<int>(nullable: false),
                    TaskID = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    Hour = table.Column<int>(nullable: false),
                    ID = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerReports", x => new { x.ProjectID, x.TaskID, x.EmployeeID });
                    table.ForeignKey(
                        name: "FK_WorkerReports_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalSchema: "MO",
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkerReports_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalSchema: "MO",
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkerReports_Tasks_TaskID",
                        column: x => x.TaskID,
                        principalSchema: "MO",
                        principalTable: "Tasks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkerReports_EmployeeID",
                schema: "MO",
                table: "WorkerReports",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerReports_TaskID",
                schema: "MO",
                table: "WorkerReports",
                column: "TaskID");
        }
    }
}
