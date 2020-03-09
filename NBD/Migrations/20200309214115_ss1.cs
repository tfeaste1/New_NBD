using Microsoft.EntityFrameworkCore.Migrations;

namespace NBD.Migrations
{
    public partial class ss1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeLabour_Employees_EmployeeID",
                schema: "NC",
                table: "EmployeeLabour");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeLabour_Projects_ProjectID",
                schema: "NC",
                table: "EmployeeLabour");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeLabour",
                schema: "NC",
                table: "EmployeeLabour");

            migrationBuilder.RenameTable(
                name: "EmployeeLabour",
                schema: "NC",
                newName: "EmployeeLabours",
                newSchema: "NC");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeLabour_EmployeeID",
                schema: "NC",
                table: "EmployeeLabours",
                newName: "IX_EmployeeLabours_EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeLabours",
                schema: "NC",
                table: "EmployeeLabours",
                columns: new[] { "ProjectID", "EmployeeID" });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeLabours_Employees_EmployeeID",
                schema: "NC",
                table: "EmployeeLabours",
                column: "EmployeeID",
                principalSchema: "NC",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeLabours_Projects_ProjectID",
                schema: "NC",
                table: "EmployeeLabours",
                column: "ProjectID",
                principalSchema: "NC",
                principalTable: "Projects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeLabours_Employees_EmployeeID",
                schema: "NC",
                table: "EmployeeLabours");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeLabours_Projects_ProjectID",
                schema: "NC",
                table: "EmployeeLabours");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeLabours",
                schema: "NC",
                table: "EmployeeLabours");

            migrationBuilder.RenameTable(
                name: "EmployeeLabours",
                schema: "NC",
                newName: "EmployeeLabour",
                newSchema: "NC");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeLabours_EmployeeID",
                schema: "NC",
                table: "EmployeeLabour",
                newName: "IX_EmployeeLabour_EmployeeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeLabour",
                schema: "NC",
                table: "EmployeeLabour",
                columns: new[] { "ProjectID", "EmployeeID" });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeLabour_Employees_EmployeeID",
                schema: "NC",
                table: "EmployeeLabour",
                column: "EmployeeID",
                principalSchema: "NC",
                principalTable: "Employees",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeLabour_Projects_ProjectID",
                schema: "NC",
                table: "EmployeeLabour",
                column: "ProjectID",
                principalSchema: "NC",
                principalTable: "Projects",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
