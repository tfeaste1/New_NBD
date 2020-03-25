using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NBD.Data.NBDMigrations
{
    public partial class s1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkerReports",
                schema: "MO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Hours = table.Column<int>(nullable: false),
                    Costs = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: false),
                    ProjectID = table.Column<int>(nullable: false),
                    TaskID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerReports", x => x.ID);
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

            migrationBuilder.CreateIndex(
                name: "IX_WorkerReports_ProjectID_TaskID_EmployeeID",
                schema: "MO",
                table: "WorkerReports",
                columns: new[] { "ProjectID", "TaskID", "EmployeeID" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkerReports",
                schema: "MO");
        }
    }
}
