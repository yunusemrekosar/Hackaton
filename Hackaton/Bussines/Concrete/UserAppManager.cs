using Hackaton.Bussines.Abstract;
using Hackaton.DAL.Abstract;

namespace Hackaton.Bussines.Concrete
{
    public class UserAppManager: IUserAppService
    {
        private readonly IUserAppDal _userAppDal;

        public UserAppManager(IUserAppDal userAppDal)
        {
            _userAppDal = userAppDal;
        }


    }
}
