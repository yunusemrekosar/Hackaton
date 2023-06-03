using Hackaton.DAL.Abstract;
using Hackaton.Data;
using Hackaton.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Hackaton.DAL.Concrete
{
    public class UserStatusDall : BaseDal<UserStatus>, IUserStatusDal
    {
        readonly ApplicationDbContext _context;

        public UserStatusDall(ApplicationDbContext context) : base(context)
        {
        }
    }
}
