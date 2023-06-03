using Hackaton.DAL.Abstract;
using Hackaton.Data;
using Hackaton.Data.Entity;

namespace Hackaton.DAL.Concrete
{
    public class RoleAppDal : BaseDal<RoleApp>, IRoleAppDal
    {
        public RoleAppDal(ApplicationDbContext context) : base(context)
        {
        }
    }
}
