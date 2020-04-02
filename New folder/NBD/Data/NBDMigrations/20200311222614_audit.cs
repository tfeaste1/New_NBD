using Microsoft.EntityFrameworkCore.Migrations;

namespace NBD.Data.NBDMigrations
{
    public partial class audit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TeamName",
                schema: "MO",
                table: "Teams",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TeamName",
                schema: "MO",
                table: "Teams",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
