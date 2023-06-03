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
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<IBaseClass>();
            foreach (var data in datas)
            {
                switch (data.State)
                {
                    case EntityState.Added:
                        data.Entity.CreatedOn = DateTime.Now;
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