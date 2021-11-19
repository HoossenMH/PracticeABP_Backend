using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PracticeABP.Authorization.Roles;
using PracticeABP.Authorization.Users;
using PracticeABP.MultiTenancy;

namespace PracticeABP.EntityFrameworkCore
{
    public class PracticeABPDbContext : AbpZeroDbContext<Tenant, Role, User, PracticeABPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<PracticeABP.Players.Player> Players { get; set; }

        public PracticeABPDbContext(DbContextOptions<PracticeABPDbContext> options)
            : base(options)
        {
        }
    }
}
