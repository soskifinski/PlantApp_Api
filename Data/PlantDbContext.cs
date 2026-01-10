using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using PlantApp.Api.Models;

namespace PlantApp.Api.Data
{
    public class PlantDbContext : IdentityDbContext<ApplicationUser>
    {
        public PlantDbContext()
        {
        }

        public PlantDbContext(DbContextOptions<PlantDbContext> options)
            : base(options) { }

        public DbSet<Plant> Plants => Set<Plant>();
        public DbSet<UserPlant> UserPlants => Set<UserPlant>();
        public DbSet<Models.Task> Tasks => base.Set<Models.Task>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Server=localhost\\SQLEXPRESS02;Database=PlantAppDb");            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserPlant>()
                .HasOne(up => up.User)
                .WithMany(u => u.UserPlants)
                .HasForeignKey(up => up.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserPlant>()
                .HasOne(up => up.Plant)
                .WithMany(u => u.UserPlants)
                .HasForeignKey(up => up.PlantId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Models.Task>()
               .HasOne(t => t.UserPlant)
               .WithMany(up => up.Tasks)
               .HasForeignKey(t => t.UserPlantId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
