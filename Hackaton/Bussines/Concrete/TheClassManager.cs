using Hackaton.Bussines.Abstract;
using Hackaton.DAL.Abstract;

namespace Hackaton.Bussines.Concrete
{
    public class TheClassManager: ITheClassService
    {
        private readonly ITheClassDal _theClassDal;

        public TheClassManager(ITheClassDal theClassDal)
        {
            _theClassDal = theClassDal;
        }


    }
}
