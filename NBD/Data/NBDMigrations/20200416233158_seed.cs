using Microsoft.EntityFrameworkCore.Migrations;

namespace NBD.Data.NBDMigrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductionStageReports_ProjectID",
                schema: "MO",
                table: "ProductionStageReports");

            migrationBuilder.DropIndex(
                name: "IX_BidStageReports_ProjectID",
                schema: "MO",
                table: "BidStageReports");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionStageReports_ProjectID_Id",
                schema: "MO",
                table: "ProductionStageReports",
                columns: new[] { "ProjectID", "Id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BidStageReports_ProjectID_Id",
                schema: "MO",
                table: "BidStageReports",
                columns: new[] { "ProjectID", "Id" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductionStageReports_ProjectID_Id",
                schema: "MO",
                table: "ProductionStageReports");

            migrationBuilder.DropIndex(
                name: "IX_BidStageReports_ProjectID_Id",
                schema: "MO",
                table: "BidStageReports");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionStageReports_ProjectID",
                schema: "MO",
                table: "ProductionStageReports",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_BidStageReports_ProjectID",
                schema: "MO",
                table: "BidStageReports",
                column: "ProjectID");
        }
    }
}
