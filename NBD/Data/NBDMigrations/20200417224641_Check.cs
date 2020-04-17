using Microsoft.EntityFrameworkCore.Migrations;

namespace NBD.Data.NBDMigrations
{
    public partial class Check : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProductionStageReports_ProjectID_Id",
                schema: "MO",
                table: "ProductionStageReports");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "MO",
                table: "BidStageReports",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_BidStageReports_ProjectID_Id",
                schema: "MO",
                table: "BidStageReports",
                newName: "IX_BidStageReports_ProjectID_ID");

            migrationBuilder.AddColumn<int>(
                name: "ProductionPlanID",
                schema: "MO",
                table: "ProductionStageReports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductionStageReports_ProductionPlanID",
                schema: "MO",
                table: "ProductionStageReports",
                column: "ProductionPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionStageReports_ProjectID_ProductionPlanID_Id",
                schema: "MO",
                table: "ProductionStageReports",
                columns: new[] { "ProjectID", "ProductionPlanID", "Id" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductionStageReports_ProductionPlan_ProductionPlanID",
                schema: "MO",
                table: "ProductionStageReports",
                column: "ProductionPlanID",
                principalSchema: "MO",
                principalTable: "ProductionPlan",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductionStageReports_ProductionPlan_ProductionPlanID",
                schema: "MO",
                table: "ProductionStageReports");

            migrationBuilder.DropIndex(
                name: "IX_ProductionStageReports_ProductionPlanID",
                schema: "MO",
                table: "ProductionStageReports");

            migrationBuilder.DropIndex(
                name: "IX_ProductionStageReports_ProjectID_ProductionPlanID_Id",
                schema: "MO",
                table: "ProductionStageReports");

            migrationBuilder.DropColumn(
                name: "ProductionPlanID",
                schema: "MO",
                table: "ProductionStageReports");

            migrationBuilder.RenameColumn(
                name: "ID",
                schema: "MO",
                table: "BidStageReports",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_BidStageReports_ProjectID_ID",
                schema: "MO",
                table: "BidStageReports",
                newName: "IX_BidStageReports_ProjectID_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionStageReports_ProjectID_Id",
                schema: "MO",
                table: "ProductionStageReports",
                columns: new[] { "ProjectID", "Id" },
                unique: true);
        }
    }
}
