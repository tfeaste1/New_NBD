using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NBD.Data.NBDMigrations
{
    public partial class produbidreport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BidStageReports",
                schema: "MO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProjectName = table.Column<string>(nullable: true),
                    EstimatedBid = table.Column<string>(nullable: true),
                    ActualDesingHours = table.Column<string>(nullable: true),
                    EstimatedDesingHours = table.Column<string>(nullable: true),
                    ActualDesingCost = table.Column<string>(nullable: true),
                    EstimatedDesingCost = table.Column<string>(nullable: true),
                    Hours = table.Column<string>(nullable: true),
                    Remaining = table.Column<string>(nullable: true),
                    ProjectID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BidStageReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BidStageReports_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalSchema: "MO",
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductionStageReports",
                schema: "MO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProjectName = table.Column<string>(nullable: true),
                    Bid = table.Column<string>(nullable: true),
                    EstProdPlan = table.Column<string>(nullable: true),
                    TotalCosttoDate = table.Column<string>(nullable: true),
                    ActualMtl = table.Column<string>(nullable: true),
                    EstimatedDesingCost = table.Column<string>(nullable: true),
                    ActuLaborPro = table.Column<string>(nullable: true),
                    EstLaborProdCost = table.Column<string>(nullable: true),
                    ActuLaborDesingCost = table.Column<string>(nullable: true),
                    EstLaborDesingCost = table.Column<string>(nullable: true),
                    ProjectID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionStageReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductionStageReports_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalSchema: "MO",
                        principalTable: "Projects",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BidStageReports_ProjectID",
                schema: "MO",
                table: "BidStageReports",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductionStageReports_ProjectID",
                schema: "MO",
                table: "ProductionStageReports",
                column: "ProjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BidStageReports",
                schema: "MO");

            migrationBuilder.DropTable(
                name: "ProductionStageReports",
                schema: "MO");
        }
    }
}
