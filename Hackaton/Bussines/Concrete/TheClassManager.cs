using AutoMapper;
using Hackaton.Bussines.Abstract;
using Hackaton.DAL.Abstract;
using Hackaton.Data.Entity;
using Hackaton.Models.TheClass;

namespace Hackaton.Bussines.Concrete
{
    public class TheClassManager : ITheClassService
    {
        private readonly ITheClassDal _theClassDal;
        private readonly IMapper _mapper;

        public TheClassManager(ITheClassDal theClassDal, IMapper mapper)
        {
            _theClassDal = theClassDal;
            _mapper = mapper;
        }

        public bool AddClass(AddTheClassModel theClass)
        {
            TheClass Class = _mapper.Map<TheClass>(theClass);
            _theClassDal.Create(Class);
            return true;
        }

        public bool DeleteClass(int classId)
        {
           return _theClassDal.Delete(classId);
        }

        public List<TheClass> GetAllClasses()
        {
            return _theClassDal.GetAll();
        }

        public bool UpdateClass(UpdateTheClassModel theClass)
        {
            TheClass Class = _mapper.Map<TheClass>(theClass);
            _theClassDal.Update(Class);
            return true;
        }
    }
}
