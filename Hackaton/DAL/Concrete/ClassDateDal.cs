using Hackaton.Bussines.Abstract;
using Hackaton.DAL.Abstract;
using Hackaton.Data;
using Hackaton.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Hackaton.DAL.Concrete
{
    public class ClassDateDal : BaseDal<ClassDate>, IClassDateDal
    {
        readonly ApplicationDbContext _context;
        public ClassDateDal(ApplicationDbContext context) : base(context)
        {
            _context = context;

        }
        public override List<ClassDate> GetAll()
        {
            try
            {
                return _context.ClassDates.Include(x=>x.TheClass).ToList();
                
            }
            catch
            {
                return null;
            }
        }
        public override List<ClassDate> GetWhere(Expression<Func<ClassDate, bool>> expression)
        {
            try
            {
                return _context.ClassDates.Include(x => x.TheClass).Where(expression).ToList();

            }
            catch
            {
                return null;
            }
        }
    }
}
