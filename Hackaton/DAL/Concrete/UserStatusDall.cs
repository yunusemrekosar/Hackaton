using Hackaton.DAL.Abstract;
using Hackaton.Data;
using Hackaton.Data.Entity;

namespace Hackaton.DAL.Concrete
{
    public class UserStatusDall : BaseDal<UserStatus>, IUserStatusDal
    {
        public UserStatusDall(ApplicationDbContext context) : base(context)
        {
        }
    }
}
