﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NBD.Data;

namespace NBD.Data.NBDMigrations
{
    [DbContext(typeof(NBDContext))]
    [Migration("20200325185631_s1")]
    partial class s1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("MO")
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NBD.Models.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("NBD.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<int>("CityID");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<long>("PhoneNumber");

                    b.Property<string>("Position");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<string>("Province")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("NBD.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float?>("Cost");

                    b.Property<string>("Description");

                    b.Property<float?>("Price");

                    b.HasKey("ID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("NBD.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentID");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<long>("PhoneNumber");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("NBD.Models.Inventory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float?>("AvgNet");

                    b.Property<float?>("List");

                    b.Property<int>("MaterialID");

                    b.Property<int>("Quantity");

                    b.Property<int>("SizeAmount");

                    b.Property<string>("SizeUnit");

                    b.HasKey("ID");

                    b.HasIndex("MaterialID");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("NBD.Models.LabourRequirement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comments");

                    b.Property<DateTime?>("Date");

                    b.Property<DateTime?>("EstDate");

                    b.Property<int>("EstHours");

                    b.Property<int>("Hours");

                    b.Property<int>("TaskID");

                    b.Property<int>("TeamID");

                    b.HasKey("ID");

                    b.HasIndex("TaskID");

                    b.HasIndex("TeamID");

                    b.ToTable("LabourRequirements");
                });

            modelBuilder.Entity("NBD.Models.LabourSummary", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentID");

                    b.Property<int>("Hours");

                    b.Property<int>("ProjectID");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("ProjectID");

                    b.ToTable("LabourSummaries");
                });

            modelBuilder.Entity("NBD.Models.Material", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Type");

                    b.HasKey("ID");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("NBD.Models.MaterialRequirement", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DeliveryDate");

                    b.Property<DateTime?>("DeliveryTime");

                    b.Property<int>("EstQuantity");

                    b.Property<DateTime?>("InstallDate");

                    b.Property<DateTime?>("InstallTime");

                    b.Property<int>("InventoryID");

                    b.Property<int>("Quantity");

                    b.HasKey("ID");

                    b.HasIndex("InventoryID");

                    b.ToTable("MaterialRequirements");
                });

            modelBuilder.Entity("NBD.Models.ProdPlanLabour", b =>
                {
                    b.Property<int>("ProdPlanID");

                    b.Property<int>("LabourReqID");

                    b.Property<int?>("LabourRequirementID");

                    b.Property<int?>("ProductionPlanID");

                    b.HasKey("ProdPlanID", "LabourReqID");

                    b.HasIndex("LabourRequirementID");

                    b.HasIndex("ProductionPlanID");

                    b.ToTable("ProdPlanLabours");
                });

            modelBuilder.Entity("NBD.Models.ProdPlanMaterial", b =>
                {
                    b.Property<int>("MaterialReqID");

                    b.Property<int>("ProdPlanID");

                    b.Property<int?>("MaterialRequirementID");

                    b.Property<int?>("ProductionPlanID");

                    b.HasKey("MaterialReqID", "ProdPlanID");

                    b.HasIndex("MaterialRequirementID");

                    b.HasIndex("ProductionPlanID");

                    b.ToTable("ProdPlanMaterials");
                });

            modelBuilder.Entity("NBD.Models.ProductionPlan", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProjectID");

                    b.Property<int>("TeamID");

                    b.HasKey("ID");

                    b.HasIndex("ProjectID");

                    b.HasIndex("TeamID");

                    b.ToTable("ProductionPlan");
                });

            modelBuilder.Entity("NBD.Models.ProductionTool", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("EarliestDelivery");

                    b.Property<DateTime?>("LatestDelivery");

                    b.Property<int>("ProjectID");

                    b.Property<int>("Quantity");

                    b.Property<int>("ToolID");

                    b.HasKey("ID");

                    b.HasIndex("ProjectID");

                    b.HasIndex("ToolID");

                    b.ToTable("ProductionTools");
                });

            modelBuilder.Entity("NBD.Models.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float?>("ActAmount");

                    b.Property<bool>("AdminApproval");

                    b.Property<bool>("ClientApproval");

                    b.Property<int?>("ClientID")
                        .IsRequired();

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<DateTime?>("EndDate");

                    b.Property<float?>("EstAmount")
                        .IsRequired();

                    b.Property<DateTime?>("EstEndDate")
                        .IsRequired();

                    b.Property<DateTime?>("EstStartDate")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime?>("ProjBidDate")
                        .IsRequired();

                    b.Property<string>("ProjCurrentPhase");

                    b.Property<bool>("ProjIsFlagged");

                    b.Property<string>("ProjSite");

                    b.Property<DateTime?>("StartDate");

                    b.Property<int?>("ToolID");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("ToolID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("NBD.Models.ProjectLabour", b =>
                {
                    b.Property<int>("ProjectID");

                    b.Property<int>("LabourReqID");

                    b.Property<int?>("LabourRequirementID");

                    b.HasKey("ProjectID", "LabourReqID");

                    b.HasIndex("LabourRequirementID");

                    b.ToTable("ProjectLabours");
                });

            modelBuilder.Entity("NBD.Models.ProjectMaterial", b =>
                {
                    b.Property<int>("ProjectID");

                    b.Property<int>("MaterialReqID");

                    b.Property<int?>("MaterialRequirementID");

                    b.HasKey("ProjectID", "MaterialReqID");

                    b.HasIndex("MaterialRequirementID");

                    b.ToTable("ProjectMaterials");
                });

            modelBuilder.Entity("NBD.Models.Task", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("StdTimeAmnt");

                    b.Property<string>("stdTimeUnit");

                    b.HasKey("ID");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("NBD.Models.Team", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeID");

                    b.Property<string>("Phase");

                    b.Property<int>("ProjectID");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("ProjectID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("NBD.Models.Tool", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.HasKey("ID");

                    b.ToTable("Tools");
                });

            modelBuilder.Entity("NBD.Models.WorkerReport", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Costs");

                    b.Property<DateTime?>("Date");

                    b.Property<int>("EmployeeID");

                    b.Property<int>("Hours");

                    b.Property<int>("ProjectID");

                    b.Property<int>("TaskID");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("TaskID");

                    b.HasIndex("ProjectID", "TaskID", "EmployeeID")
                        .IsUnique();

                    b.ToTable("WorkerReports");
                });

            modelBuilder.Entity("NBD.Models.Client", b =>
                {
                    b.HasOne("NBD.Models.City", "City")
                        .WithMany("Clients")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NBD.Models.Employee", b =>
                {
                    b.HasOne("NBD.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("NBD.Models.Inventory", b =>
                {
                    b.HasOne("NBD.Models.Material", "Material")
                        .WithMany("Inventories")
                        .HasForeignKey("MaterialID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("NBD.Models.LabourRequirement", b =>
                {
                    b.HasOne("NBD.Models.Task", "Task")
                        .WithMany("LabourRequirements")
                        .HasForeignKey("TaskID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("NBD.Models.Team", "Team")
                        .WithMany("LabourRequirements")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("NBD.Models.LabourSummary", b =>
                {
                    b.HasOne("NBD.Models.Department", "Department")
                        .WithMany("LabourSummaries")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NBD.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NBD.Models.MaterialRequirement", b =>
                {
                    b.HasOne("NBD.Models.Inventory", "Inventory")
                        .WithMany("MaterialRequirements")
                        .HasForeignKey("InventoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NBD.Models.ProdPlanLabour", b =>
                {
                    b.HasOne("NBD.Models.LabourRequirement", "LabourRequirement")
                        .WithMany("ProdPlanLabours")
                        .HasForeignKey("LabourRequirementID");

                    b.HasOne("NBD.Models.ProductionPlan", "ProductionPlan")
                        .WithMany("ProdPlanLabours")
                        .HasForeignKey("ProductionPlanID");
                });

            modelBuilder.Entity("NBD.Models.ProdPlanMaterial", b =>
                {
                    b.HasOne("NBD.Models.MaterialRequirement", "MaterialRequirement")
                        .WithMany("ProdPlanMaterials")
                        .HasForeignKey("MaterialRequirementID");

                    b.HasOne("NBD.Models.ProductionPlan", "ProductionPlan")
                        .WithMany("ProdPlanMaterials")
                        .HasForeignKey("ProductionPlanID");
                });

            modelBuilder.Entity("NBD.Models.ProductionPlan", b =>
                {
                    b.HasOne("NBD.Models.Project", "Project")
                        .WithMany("ProductionPlans")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("NBD.Models.Team", "Team")
                        .WithMany("ProductionPlans")
                        .HasForeignKey("TeamID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("NBD.Models.ProductionTool", b =>
                {
                    b.HasOne("NBD.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NBD.Models.Tool", "Tool")
                        .WithMany()
                        .HasForeignKey("ToolID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NBD.Models.Project", b =>
                {
                    b.HasOne("NBD.Models.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("NBD.Models.Tool")
                        .WithMany("Projects")
                        .HasForeignKey("ToolID");
                });

            modelBuilder.Entity("NBD.Models.ProjectLabour", b =>
                {
                    b.HasOne("NBD.Models.LabourRequirement", "LabourRequirement")
                        .WithMany("ProjectLabours")
                        .HasForeignKey("LabourRequirementID");

                    b.HasOne("NBD.Models.Project", "Project")
                        .WithMany("ProjectLabours")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NBD.Models.ProjectMaterial", b =>
                {
                    b.HasOne("NBD.Models.MaterialRequirement", "MaterialRequirement")
                        .WithMany("ProjectMaterials")
                        .HasForeignKey("MaterialRequirementID");

                    b.HasOne("NBD.Models.Project", "Project")
                        .WithMany("ProjectMaterials")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NBD.Models.Team", b =>
                {
                    b.HasOne("NBD.Models.Employee", "Employee")
                        .WithMany("Teams")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NBD.Models.Project", "Project")
                        .WithMany("Teams")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NBD.Models.WorkerReport", b =>
                {
                    b.HasOne("NBD.Models.Employee", "Employee")
                        .WithMany("WorkerReports")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NBD.Models.Project", "Project")
                        .WithMany("WorkerReports")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NBD.Models.Task", "Task")
                        .WithMany("WorkerReports")
                        .HasForeignKey("TaskID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
