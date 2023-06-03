using Hackaton.DAL.Abstract;
using Hackaton.Data;
using Hackaton.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Hackaton.DAL.Concrete
{
    public class TheClassDal : BaseDal<TheClass>, ITheClassDal
    {
        readonly ApplicationDbContext _context;

        public TheClassDal(ApplicationDbContext context) : base(context)
        {
        }
            
        public override List<TheClass> GetAll()
        {
            try
            {
                return _context.Classes.Include(x => x.Users).Include(b => b.ClassDates).Include(w=>w.Department).ToList(); //todo isimlere bka
            }
            catch
            {
                return null;
            }
        }
        public override List<TheClass> GetWhere(Expression<Func<TheClass, bool>> expression)
        {
            try
            {
                return _context.Classes.Include(x => x.Users).Include(b => b.ClassDates).Include(w => w.Department).Where(expression).ToList();

            }
            catch
            {
                return null;
            }
        }
    }
}
