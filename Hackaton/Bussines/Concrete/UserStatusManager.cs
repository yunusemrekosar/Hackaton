using Hackaton.Bussines.Abstract;
using Hackaton.DAL.Abstract;

namespace Hackaton.Bussines.Concrete
{
    public class UserStatusManager: IUserStatusService
    {
        private readonly IUserStatusDal _userStatusDal;

        public UserStatusManager(IUserStatusDal userStatusDal)
        {
            _userStatusDal = userStatusDal;
        }


    }
}
