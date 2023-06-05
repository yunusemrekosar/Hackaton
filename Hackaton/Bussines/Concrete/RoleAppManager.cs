using Hackaton.Bussines.Abstract;
using Hackaton.DAL.Abstract;

namespace Hackaton.Bussines.Concrete
{
    public class RoleAppManager: IRoleAppService
    {
        private readonly IRoleAppDal _roleAppDal;

        public RoleAppManager(IRoleAppDal roleAppDal)
        {
            _roleAppDal = roleAppDal;
        }


    }
}
