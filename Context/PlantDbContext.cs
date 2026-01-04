using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using PlantApp.Api.Models;

namespace PlantApp.Api.Context
{
    public class PlantDbContext : IdentityDbContext<ApplicationUser>
    {
        public PlantDbContext(DbContextOptions<PlantDbContext> options) 
            : base(options) { }

        public DbSet<UserPlant> UserPlants => Set<UserPlant>();
        public DbSet<Models.Task> Tasks => base.Set<Models.Task>();
    }
}
