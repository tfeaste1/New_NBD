using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NBD.Data.NBDMigrations
{
    public partial class krow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
   

            migrationBuilder.CreateTable(
                name: "MRs",
                schema: "MO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    date = table.Column<DateTime>(nullable: true),
                    Qnty = table.Column<int>(nullable: false),
                    Cost = table.Column<int>(nullable: false),
                    MaterialID = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false),
                    ProjectID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MRs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MRs_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalSchema: "MO",
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MRs_Materials_MaterialID",
                        column: x => x.MaterialID,
                        principalSchema: "MO",
                        principalTable: "Materials",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MRs_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalSchema: "MO",
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MRs_EmployeeID",
                schema: "MO",
                table: "MRs",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_MRs_MaterialID",
                schema: "MO",
                table: "MRs",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_MRs_ProjectID_MaterialID_EmployeeID",
                schema: "MO",
                table: "MRs",
                columns: new[] { "ProjectID", "MaterialID", "EmployeeID" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MRs",
                schema: "MO");

            
        }
    }
}
