using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NBD.Models;

namespace NBD.Data
{
    public class NBDContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public string UserName
        {
            get; private set;
        }

        public NBDContext (DbContextOptions<NBDContext> options)
            : base(options)
        {
            UserName = "SeedData";
        }

        public NBDContext(DbContextOptions<NBDContext> options, IHttpContextAccessor httpContextAccessor)
           : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
            UserName = _httpContextAccessor.HttpContext?.User.Identity.Name;
            //UserName = (UserName == null) ? "Unknown" : UserName;
            UserName = UserName ?? "Unknown";
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
        //public DbSet<LabourRequirement> LabourRequirements { get; set; }

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

            //modelBuilder.Entity<LabourRequirement>()
            //.HasKey(lr => new { lr.TeamID, lr.TaskID });


        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSaving();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            OnBeforeSaving();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }


        private void OnBeforeSaving()
        {
            var entries = ChangeTracker.Entries();
            foreach (var entry in entries)
            {
                if (entry.Entity is IAuditable trackable)
                {
                    var now = DateTime.UtcNow;
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            trackable.UpdatedOn = now;
                            trackable.UpdatedBy = UserName;
                            break;

                        case EntityState.Added:
                            trackable.CreatedOn = now;
                            trackable.CreatedBy = UserName;
                            trackable.UpdatedOn = now;
                            trackable.UpdatedBy = UserName;
                            break;
                    }
                }
            }
        }
    }
}
