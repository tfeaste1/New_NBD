using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NBD.Migrations
{
    public partial class design : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DesignReports",
                schema: "MO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Hour = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: false),
                    ProjectID = table.Column<int>(nullable: false),
                    TaskID = table.Column<int>(nullable: false),
                    StageID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesignReports", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DesignReports_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalSchema: "MO",
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DesignReports_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalSchema: "MO",
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DesignReports_Stages_StageID",
                        column: x => x.StageID,
                        principalSchema: "MO",
                        principalTable: "Stages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DesignReports_Tasks_TaskID",
                        column: x => x.TaskID,
                        principalSchema: "MO",
                        principalTable: "Tasks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DesignReports_EmployeeID",
                schema: "MO",
                table: "DesignReports",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_DesignReports_StageID",
                schema: "MO",
                table: "DesignReports",
                column: "StageID");

            migrationBuilder.CreateIndex(
                name: "IX_DesignReports_TaskID",
                schema: "MO",
                table: "DesignReports",
                column: "TaskID");

            migrationBuilder.CreateIndex(
                name: "IX_DesignReports_ProjectID_TaskID_EmployeeID_StageID",
                schema: "MO",
                table: "DesignReports",
                columns: new[] { "ProjectID", "TaskID", "EmployeeID", "StageID" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DesignReports",
                schema: "MO");
        }
    }
}
