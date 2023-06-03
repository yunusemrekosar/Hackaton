using Hackaton.Bussines.Abstract;
using Hackaton.Core;
using Hackaton.DAL.Abstract;
using Hackaton.Data.Entity;
using Hackaton.Models.TheClass;

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

        public bool AddClass(AddTheClassModel theClass)
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

        public bool UpdateClass(UpdateTheClassModel theClass)
        {
            throw new NotImplementedException();
        }
    }
}
