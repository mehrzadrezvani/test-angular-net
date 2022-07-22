using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using angular-net.Authorization.Roles;
using angular-net.Authorization.Users;
using angular-net.MultiTenancy;

namespace angular-net.EntityFrameworkCore
{
    public class angular-netDbContext : AbpZeroDbContext<Tenant, Role, User, angular-netDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public angular-netDbContext(DbContextOptions<angular-netDbContext> options)
            : base(options)
        {
        }
    }
}
