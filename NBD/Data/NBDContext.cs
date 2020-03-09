using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NBD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.AspNetCore.Http;
using System.Threading;

namespace NBD.Data
{
    public class NBDContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public string UserName
        {
            get; private set;
        }
        public NBDContext(DbContextOptions<NBDContext> options)
            : base(options)
        {
            UserName = "SeedData";
        }

        public NBDContext (DbContextOptions<NBDContext> options, IHttpContextAccessor httpContextAccessor)
           : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
            UserName = _httpContextAccessor.HttpContext?.User.Identity.Name;
            //UserName = (UserName == null) ? "Unknown" : UserName;
            UserName = UserName ?? "Unknown";
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectInventory> ProjectInventories { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<NBD.Models.EmployeeLabour> EmployeeLabours { get; set; }






        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("NC");


            modelBuilder.Entity<Department>()
                .HasMany<Employee>(d => d.Employees)
                .WithOne(e => e.Department)
                .HasForeignKey(e => e.DepartmentID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Category>()
                .HasMany<Inventory>(c => c.Inventories)
                .WithOne(m => m.Category)
                .HasForeignKey(m => m.CategoryID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Inventory>()
                .HasMany<ProjectInventory>(c => c.ProjectInventories)
                .WithOne(m => m.Inventory)
                .HasForeignKey(m => m.InventoryID)
                .OnDelete(DeleteBehavior.Restrict);




            //unique index

            modelBuilder.Entity<Employee>()
             .HasIndex(e => new { e.Email })
             .IsUnique();

            modelBuilder.Entity<Inventory>()
             .HasIndex(i => new { i.Code })
             .IsUnique();

            modelBuilder.Entity<Client>()
            .HasIndex(c => new { c.Email })
            .IsUnique();


            // many to many

            modelBuilder.Entity<ProjectInventory>()
           .HasKey(p => new { p.ProjectID, p.InventoryID });

            modelBuilder.Entity<Team>()
           .HasKey(t => new { t.ProjectID, t.EmployeeID });

            modelBuilder.Entity<EmployeeLabour>()
.HasKey(t => new { t.ProjectID, t.EmployeeID });




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
