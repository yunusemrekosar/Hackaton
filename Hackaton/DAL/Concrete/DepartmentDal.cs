using Hackaton.DAL.Abstract;
using Hackaton.Data;
using Hackaton.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Hackaton.DAL.Concrete
{
    public class DepartmentDal : BaseDal<Department>, IDepartmentDal
    {
        readonly ApplicationDbContext _context;

        public DepartmentDal(ApplicationDbContext context) : base(context)
        {
            _context = context;

        }
        public override List<Department> GetAll()
        {
            try
            {
                return _context.Departments.Include(x => x.Classes).ToList(); 
            }
            catch
            {
                return null;
            }
        }
        public override List<Department> GetWhere(Expression<Func<Department, bool>> expression)
        {
            try
            {
                return _context.Departments.Include(x => x.Classes).Where(expression).ToList();

            }
            catch
            {
                return null;
            }
        }
    }
}
