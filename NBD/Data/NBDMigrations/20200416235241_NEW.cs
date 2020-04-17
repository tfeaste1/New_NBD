using Microsoft.EntityFrameworkCore.Migrations;

namespace NBD.Data.NBDMigrations
{
    public partial class NEW : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectName",
                schema: "MO",
                table: "ProductionStageReports");

            migrationBuilder.DropColumn(
                name: "ProjectName",
                schema: "MO",
                table: "BidStageReports");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectName",
                schema: "MO",
                table: "ProductionStageReports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectName",
                schema: "MO",
                table: "BidStageReports",
                nullable: true);
        }
    }
}
