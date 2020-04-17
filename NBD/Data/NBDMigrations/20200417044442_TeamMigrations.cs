using Microsoft.EntityFrameworkCore.Migrations;

namespace NBD.Data.NBDMigrations
{
    public partial class TeamMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Employees_EmployeeID",
                schema: "MO",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Projects_ProjectID",
                schema: "MO",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_EmployeeID",
                schema: "MO",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                schema: "MO",
                table: "Teams");

            migrationBuilder.AddColumn<string>(
                name: "TeamName",
                schema: "MO",
                table: "Teams",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "TeamID",
                schema: "MO",
                table: "Projects",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TeamEmployees",
                schema: "MO",
                columns: table => new
                {
                    TeamID = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamEmployees", x => new { x.TeamID, x.EmployeeID });
                    table.ForeignKey(
                        name: "FK_TeamEmployees_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalSchema: "MO",
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamEmployees_Teams_TeamID",
                        column: x => x.TeamID,
                        principalSchema: "MO",
                        principalTable: "Teams",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TeamID",
                schema: "MO",
                table: "Projects",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_TeamEmployees_EmployeeID",
                schema: "MO",
                table: "TeamEmployees",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Teams_TeamID",
                schema: "MO",
                table: "Projects",
                column: "TeamID",
                principalSchema: "MO",
                principalTable: "Teams",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Projects_ProjectID",
                schema: "MO",
                table: "Teams",
                column: "ProjectID",
                principalSchema: "MO",
                principalTable: "Projects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Teams_TeamID",
                schema: "MO",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Projects_ProjectID",
                schema: "MO",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "TeamEmployees",
                schema: "MO");

            migrationBuilder.DropIndex(
                name: "IX_Projects_TeamID",
                schema: "MO",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TeamName",
                schema: "MO",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamID",
                schema: "MO",
                table: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                schema: "MO",
                table: "Teams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_EmployeeID",
                schema: "MO",
                table: "Teams",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Employees_EmployeeID",
                schema: "MO",
                table: "Teams",
                column: "EmployeeID",
                principalSchema: "MO",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Projects_ProjectID",
                schema: "MO",
                table: "Teams",
                column: "ProjectID",
                principalSchema: "MO",
                principalTable: "Projects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
