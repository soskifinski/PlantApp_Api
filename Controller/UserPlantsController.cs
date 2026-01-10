using System.Security.Claims;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using PlantApp.Api.Data;
using PlantApp.Api.Models;

namespace PlantApp.Api.Controller
{
    [Authorize]
    [ApiController]
    [Route("api/account")]
    public class UserPlantsController : ControllerBase
    {
        private readonly PlantDbContext _db;

        public UserPlantsController(PlantDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IEnumerable<UserPlant>> Get()
        {
            string? userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return await _db.UserPlants.Where(p => p.UserId.Equals(userId)).ToListAsync();
        }
    }

}
