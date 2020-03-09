using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NBD.Models;

namespace NBD.Data
{
    public class NBDContext : DbContext
    {
        public NBDContext (DbContextOptions<NBDContext> options)
            : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LabourSummary> LabourSummaries { get; set; }
        public DbSet<MaterialRequirement> MaterialRequirements { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<ProductionTool> ProductionTools { get; set; }
        public DbSet<LabourRequirement> LabourRequirements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("MO");

            //Prevent Cascade Delete
            modelBuilder.Entity<Department>()
                .HasMany<Employee>(d => d.Employees)
                .WithOne(e => e.Department)
                .HasForeignKey(e => e.DepartmentID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Client>()
               .HasMany<Project>(c => c.Projects)
               .WithOne(p => p.Client)
               .HasForeignKey(p => p.ClientID)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Material>()
              .HasMany<Inventory>(m => m.Inventories)
              .WithOne(i => i.Material)
              .HasForeignKey(i => i.MaterialID)
              .OnDelete(DeleteBehavior.Restrict);

            
            //unique Email Vlaues
            modelBuilder.Entity<Employee>()
             .HasIndex(e => new { e.Email })
             .IsUnique();

            modelBuilder.Entity<Client>()
            .HasIndex(c => new { c.Email })
            .IsUnique();

            //Many-To-Many Relationships
            modelBuilder.Entity<LabourSummary>()
           .HasKey(ls => new { ls.ProjectID, ls.DepartmentID });
            
            modelBuilder.Entity<Team>()
           .HasKey(t => new { t.ProjectID, t.EmployeeID });

            modelBuilder.Entity<MaterialRequirement>()
           .HasKey(m => new { m.InventoryID, m.ProjectID });

            modelBuilder.Entity<ProductionTool>()
            .HasKey(pt => new { pt.ProjectID, pt.ToolID });

            modelBuilder.Entity<LabourRequirement>()
            .HasKey(lr => new { lr.TeamID, lr.TaskID });


        }
    }
}
