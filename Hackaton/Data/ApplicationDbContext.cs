using Hackaton.Data.Entity;
using Hackaton.Data.Entity.Common;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Hackaton.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserApp, RoleApp, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserApp> Users { get; set; }
        public DbSet<RoleApp> Roles { get; set; }
        public DbSet<UserStatus> UserStatus { get; set; }
        public DbSet<TheClass> Classes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<ClassDate> ClassDates { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<IBaseClass>();
            foreach (var data in datas)
            {
                switch (data.State)
                {
                    case EntityState.Added:
                        data.Entity.CreatedOn = DateTime.Now;
                        data.Entity.UpdatedOn = DateTime.Now;
                        data.Entity.IsActive = true;
                        break;

                    case EntityState.Modified:
                        data.Entity.UpdatedOn = DateTime.Now;
                        break;
                }

            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}