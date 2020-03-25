using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NBD.Data.NBDMigrations
{
    public partial class s3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MaterialReports",
                schema: "MO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<int>(nullable: false),
                    Costs = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: true),
                    EmployeeID = table.Column<int>(nullable: false),
                    ProjectID = table.Column<int>(nullable: false),
                    MaterialID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialReports", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MaterialReports_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalSchema: "MO",
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialReports_Materials_MaterialID",
                        column: x => x.MaterialID,
                        principalSchema: "MO",
                        principalTable: "Materials",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialReports_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalSchema: "MO",
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialReports_EmployeeID",
                schema: "MO",
                table: "MaterialReports",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialReports_MaterialID",
                schema: "MO",
                table: "MaterialReports",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialReports_ProjectID_MaterialID_EmployeeID",
                schema: "MO",
                table: "MaterialReports",
                columns: new[] { "ProjectID", "MaterialID", "EmployeeID" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialReports",
                schema: "MO");
        }
    }
}
