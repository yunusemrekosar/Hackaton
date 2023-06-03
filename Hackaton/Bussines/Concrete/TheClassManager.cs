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

        public bool DeleteClass(int classId)
        {
           return _theClassDal.Delete(classId);
        }

        public List<TheClass> GetAllClasses()
        {
            return _theClassDal.GetAll();
        }

        public bool UpdateClass(AddClassModel TheClass)
        {
            throw new NotImplementedException();
        }
    }
}
