using Hackaton.Bussines.Abstract;
using Hackaton.DAL.Abstract;
using Hackaton.Data.Entity;

namespace Hackaton.Bussines.Concrete
{
    public class TheClassManager : ITheClassService
    {
        private readonly ITheClassDal _theClassDal;

        public TheClassManager(ITheClassDal theClassDal)
        {
            _theClassDal = theClassDal;
        }

        public bool AddClass(TheClass theClass)
        {
            throw new NotImplementedException();
        }

        public bool DeleteClass(TheClass TheClass)
        {
            throw new NotImplementedException();
        }

        public List<TheClass> GetAllClasses()
        {
            throw new NotImplementedException();
        }

        public bool UpdateClass(TheClass TheClass)
        {
            throw new NotImplementedException();
        }
    }
}
