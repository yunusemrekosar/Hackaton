using Hackaton.DAL.Abstract;
using Hackaton.Data;
using Hackaton.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Hackaton.DAL.Concrete
{
    public class UserAppDal : BaseDal<UserApp>, IUserAppDal
    {
        readonly ApplicationDbContext _context;

        public UserAppDal(ApplicationDbContext context) : base(context)
        {
        }

        public override List<UserApp> GetAll()
        {
            try
            {
                return _context.Users.Include(p=>p.Classes).Include(p=>p.UserStatus).ToList();

            }
            catch
            {
                return null;
            }
        }
        public override List<UserApp> GetWhere(Expression<Func<UserApp, bool>> expression)
        {
            try
            {
                return _context.Users.Include(p => p.Classes).Include(p => p.UserStatus).Where(expression).ToList();

            }
            catch
            {
                return null;
            }
        }

    }
}
