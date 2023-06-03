using Hackaton.Bussines.Abstract;
using Hackaton.DAL.Abstract;
using Hackaton.Data.Entity;
using Hackaton.Models.Class;

namespace Hackaton.Bussines.Concrete
{
    public class TheClassManager : ITheClassService
    {
        private readonly ITheClassDal _theClassDal;

        public TheClassManager(ITheClassDal theClassDal)
        {
            _theClassDal = theClassDal;
        }

        

        public bool AddClass(AddClassModel theClass)
        {
            throw new NotImplementedException();
        }

        

        public bool DeleteClass(AddClassModel TheClass)
        {
            throw new NotImplementedException();
        }

        public List<TheClass> GetAllClasses()
        {
            throw new NotImplementedException();
        }


        public bool UpdateClass(AddClassModel TheClass)
        {
            throw new NotImplementedException();
        }
    }
}
