using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using PracticeABP.Authorization.Roles;
using PracticeABP.Authorization.Users;
using PracticeABP.MultiTenancy;
using PracticeABP.Players;

namespace PracticeABP.EntityFrameworkCore
{
    public class PracticeABPDbContext : AbpZeroDbContext<Tenant, Role, User, PracticeABPDbContext>
    {
        public DbSet<Player> Players { get; set; }

        public PracticeABPDbContext(DbContextOptions<PracticeABPDbContext> options)
            : base(options)
        {
        }
    }
}
