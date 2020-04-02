using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NBD.Data.NBDMigrations
{
    public partial class Fixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "MO",
                table: "Inventories",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "TeamName",
                schema: "MO",
                table: "Teams",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ProjBidDate",
                schema: "MO",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "LabourRequirement",
                schema: "MO",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EstDate = table.Column<DateTime>(nullable: true),
                    EstHours = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: true),
                    Hours = table.Column<int>(nullable: false),
                    Comments = table.Column<string>(nullable: true),
                    TeamID = table.Column<int>(nullable: false),
                    TeamProjectID = table.Column<int>(nullable: true),
                    TeamEmployeeID = table.Column<int>(nullable: true),
                    TaskID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabourRequirement", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LabourRequirement_Tasks_TaskID",
                        column: x => x.TaskID,
                        principalSchema: "MO",
                        principalTable: "Tasks",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LabourRequirement_Teams_TeamProjectID_TeamEmployeeID",
                        columns: x => new { x.TeamProjectID, x.TeamEmployeeID },
                        principalSchema: "MO",
                        principalTable: "Teams",
                        principalColumns: new[] { "ProjectID", "EmployeeID" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LabourRequirement_TaskID",
                schema: "MO",
                table: "LabourRequirement",
                column: "TaskID");

            migrationBuilder.CreateIndex(
                name: "IX_LabourRequirement_TeamProjectID_TeamEmployeeID",
                schema: "MO",
                table: "LabourRequirement",
                columns: new[] { "TeamProjectID", "TeamEmployeeID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabourRequirement",
                schema: "MO");

            migrationBuilder.RenameColumn(
                name: "ID",
                schema: "MO",
                table: "Inventories",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "TeamName",
                schema: "MO",
                table: "Teams",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ProjBidDate",
                schema: "MO",
                table: "Projects",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
