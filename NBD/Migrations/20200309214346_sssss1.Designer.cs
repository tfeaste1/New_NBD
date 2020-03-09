﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NBD.Data;

namespace NBD.Migrations
{
    [DbContext(typeof(NBDContext))]
    [Migration("20200309214346_sssss1")]
    partial class sssss1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("NC")
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NBD.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("NBD.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired();

                    b.Property<string>("City")
                        .IsRequired();

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

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<string>("Province")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("NBD.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

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

            modelBuilder.Entity("NBD.Models.EmployeeLabour", b =>
                {
                    b.Property<int>("ProjectID");

                    b.Property<int>("EmployeeID");

                    b.Property<int>("Cost");

                    b.Property<string>("EmployeeReport")
                        .IsRequired();

                    b.Property<int>("Hour");

                    b.Property<int>("ID");

                    b.HasKey("ProjectID", "EmployeeID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("EmployeeLabours");
                });

            modelBuilder.Entity("NBD.Models.Inventory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID");

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<float?>("UnitCost")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("NBD.Models.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AdminApproval");

                    b.Property<float?>("Amount")
                        .IsRequired();

                    b.Property<float?>("BidAmount")
                        .IsRequired();

                    b.Property<bool>("ClientApproval");

                    b.Property<int?>("ClientID")
                        .IsRequired();

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<DateTime?>("EndDate")
                        .IsRequired();

                    b.Property<DateTime?>("EstEndDate")
                        .IsRequired();

                    b.Property<DateTime?>("EstStartDate")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("ProdBidSite");

                    b.Property<DateTime?>("StartDate")
                        .IsRequired();

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(256);

                    b.Property<DateTime?>("UpdatedOn");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("NBD.Models.ProjectInventory", b =>
                {
                    b.Property<int>("ProjectID");

                    b.Property<int>("InventoryID");

                    b.HasKey("ProjectID", "InventoryID");

                    b.HasIndex("InventoryID");

                    b.ToTable("ProjectInventories");
                });

            modelBuilder.Entity("NBD.Models.Team", b =>
                {
                    b.Property<int>("ProjectID");

                    b.Property<int>("EmployeeID");

                    b.Property<int>("ID");

                    b.Property<string>("TeamName")
                        .IsRequired();

                    b.HasKey("ProjectID", "EmployeeID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("NBD.Models.Employee", b =>
                {
                    b.HasOne("NBD.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("NBD.Models.EmployeeLabour", b =>
                {
                    b.HasOne("NBD.Models.Employee", "Employee")
                        .WithMany("EmployeeLabour")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("NBD.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NBD.Models.Inventory", b =>
                {
                    b.HasOne("NBD.Models.Category", "Category")
                        .WithMany("Inventories")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("NBD.Models.Project", b =>
                {
                    b.HasOne("NBD.Models.Client", "Client")
                        .WithMany("Projects")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("NBD.Models.ProjectInventory", b =>
                {
                    b.HasOne("NBD.Models.Inventory", "Inventory")
                        .WithMany("ProjectInventories")
                        .HasForeignKey("InventoryID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("NBD.Models.Project", "Project")
                        .WithMany("ProjectInventories")
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
#pragma warning restore 612, 618
        }
    }
}
