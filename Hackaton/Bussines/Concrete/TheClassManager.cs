using Hackaton.Bussines.Abstract;
using Hackaton.Core;
using Hackaton.DAL.Abstract;
using Hackaton.Data.Entity;
using Hackaton.Models.Class;

namespace Hackaton.Bussines.Concrete
{
    public class TheClassManager : ITheClassService
    {
        private readonly ITheClassDal _theClassDal;
        private readonly MappingProfile _mappingProfile;

        public TheClassManager(ITheClassDal theClassDal, MappingProfile mappingProfile)
        {
            _theClassDal = theClassDal;
            _mappingProfile = mappingProfile;
        }

        public bool AddClass(AddClassModel theClass)
        {
            throw new NotImplementedException();
        }

        public bool DeleteClass(int theClassId)
        {
            throw new NotImplementedException();
        }

        public List<TheClass> GetAllClasses()
        {
            throw new NotImplementedException();
        }

        public bool UpdateClass(UpdateClassModel theClass)
        {
            throw new NotImplementedException();
        }
    }
}
