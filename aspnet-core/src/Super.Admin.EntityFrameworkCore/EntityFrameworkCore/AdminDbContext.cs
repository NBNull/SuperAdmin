using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Super.Admin.Authorization.Roles;
using Super.Admin.Authorization.Users;
using Super.Admin.MultiTenancy;

namespace Super.Admin.EntityFrameworkCore
{
    public class AdminDbContext : AbpZeroDbContext<Tenant, Role, User, AdminDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AdminDbContext(DbContextOptions<AdminDbContext> options)
            : base(options)
        {
        }
    }
}
