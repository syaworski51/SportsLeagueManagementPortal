using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportsLeagueManagementPortal.Models;

namespace SportsLeagueManagementPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SportsLeagueManagementPortal.Models.Sport> Sport { get; set; } = default!;
    }
}
