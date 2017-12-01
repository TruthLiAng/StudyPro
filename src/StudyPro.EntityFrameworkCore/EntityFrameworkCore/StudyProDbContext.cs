using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using StudyPro.Authorization.Roles;
using StudyPro.Authorization.Users;
using StudyPro.MultiTenancy;

namespace StudyPro.EntityFrameworkCore
{
    public class StudyProDbContext : AbpZeroDbContext<Tenant, Role, User, StudyProDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public StudyProDbContext(DbContextOptions<StudyProDbContext> options)
            : base(options)
        {
        }
    }
}
