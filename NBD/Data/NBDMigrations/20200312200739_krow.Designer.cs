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
    [Migration("20200312200739_krow")]
    partial class krow
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AvgNet");

                    b.Property<double>("List");

                    b.Property<int>("MaterialID");

                    b.Property<int>("Quantity");

                    b.Property<int>("SizeAmount");

                    b.Property<string>("SizeUnit");

                    b.HasKey("Id");

                    b.HasIndex("MaterialID");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("NBD.Models.LabourSummary", b =>
                {
                    b.Property<int>("ProjectID");

                    b.Property<int>("DepartmentID");

                    b.Property<int>("Hours");

                    b.Property<int>("ID");

                    b.HasKey("ProjectID", "DepartmentID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("LabourSummaries");
                });

            modelBuilder.Entity("NBD.Models.MR", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cost");

                    b.Property<int>("EmployeeID");

                    b.Property<int>("MaterialID");

                    b.Property<int>("ProjectID");

                    b.Property<int>("Qnty");

                    b.Property<DateTime?>("date");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("MaterialID");

                    b.HasIndex("ProjectID", "MaterialID", "EmployeeID")
                        .IsUnique();

                    b.ToTable("MRs");
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
                    b.Property<int>("InventoryID");

                    b.Property<int>("ProjectID");

                    b.Property<DateTime?>("DeliveryDate");

                    b.Property<DateTime?>("DeliveryTime");

                    b.Property<int>("EstQuantity");

                    b.Property<int>("ID");

                    b.Property<DateTime?>("InstallDate");

                    b.Property<DateTime?>("InstallTime");

                    b.Property<int>("Quantity");

                    b.HasKey("InventoryID", "ProjectID");

                    b.HasIndex("ProjectID");

                    b.ToTable("MaterialRequirements");
                });

            modelBuilder.Entity("NBD.Models.ProductionTool", b =>
                {
                    b.Property<int>("ProjectID");

                    b.Property<int>("ToolID");

                    b.Property<DateTime?>("EarliestDelivery");

                    b.Property<int>("ID");

                    b.Property<DateTime?>("LatestDelivery");

                    b.Property<int>("Quantity");

                    b.HasKey("ProjectID", "ToolID");

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

                    b.Property<DateTime?>("ProjBidDate");

                    b.Property<string>("ProjCurrentPhase");

                    b.Property<bool>("ProjIsFlagged");

                    b.Property<string>("ProjSite");

                    b.Property<DateTime?>("StartDate");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.ToTable("Projects");
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
                    b.Property<int>("ProjectID");

                    b.Property<int>("EmployeeID");

                    b.Property<int>("ID");

                    b.Property<string>("Phase");

                    b.Property<string>("TeamName")
                        .IsRequired();

                    b.HasKey("ProjectID", "EmployeeID");

                    b.HasIndex("EmployeeID");

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

            modelBuilder.Entity("NBD.Models.WReport", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cost");

                    b.Property<int>("EmployeeID");

                    b.Property<int>("Hour");

                    b.Property<int>("ProjectID");

                    b.Property<int>("TaskID");

                    b.Property<DateTime?>("date");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("TaskID");

                    b.HasIndex("ProjectID", "TaskID", "EmployeeID")
                        .IsUnique();

                    b.ToTable("WReports");
                });

            modelBuilder.Entity("NBD.Models.Client", b =>
                {
                    b.HasOne("NBD.Models.City", "City")
                        .WithMany()
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

            modelBuilder.Entity("NBD.Models.LabourSummary", b =>
                {
                    b.HasOne("NBD.Models.Department", "Department")
                        .WithMany("LabourSummaries")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NBD.Models.Project", "Project")
                        .WithMany("LabourSummaries")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NBD.Models.MR", b =>
                {
                    b.HasOne("NBD.Models.Employee", "Employee")
                        .WithMany("MRs")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NBD.Models.Material", "Material")
                        .WithMany("MRs")
                        .HasForeignKey("MaterialID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NBD.Models.Project", "Project")
                        .WithMany("MRs")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NBD.Models.MaterialRequirement", b =>
                {
                    b.HasOne("NBD.Models.Inventory", "Inventory")
                        .WithMany("MaterialRequirements")
                        .HasForeignKey("InventoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NBD.Models.Project", "Project")
                        .WithMany("MaterialRequirements")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NBD.Models.ProductionTool", b =>
                {
                    b.HasOne("NBD.Models.Project", "Project")
                        .WithMany("ProductionTools")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NBD.Models.Tool", "Tool")
                        .WithMany("ProductionTools")
                        .HasForeignKey("ToolID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NBD.Models.Project", b =>
                {
                    b.HasOne("NBD.Models.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Restrict);
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

            modelBuilder.Entity("NBD.Models.WReport", b =>
                {
                    b.HasOne("NBD.Models.Employee", "Employee")
                        .WithMany("WReports")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NBD.Models.Project", "Project")
                        .WithMany("WReports")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NBD.Models.Task", "Task")
                        .WithMany("WReports")
                        .HasForeignKey("TaskID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
