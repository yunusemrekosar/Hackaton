using Hackaton.DAL.Abstract;
using Hackaton.Data;
using Hackaton.Data.Entity;

namespace Hackaton.DAL.Concrete
{
    public class DepartmentDal : BaseDal<Department>, IDepartmentDal
    {
        public DepartmentDal(ApplicationDbContext context) : base(context)
        {
        }
    }
}
