using Hackaton.Data.Entity;
using Hackaton.Models.TheClass;
using System.Linq.Expressions;

namespace Hackaton.Bussines.Abstract
{
    public interface ITheClassService
    {
        public List<TheClass> GetAllClasses();
        public bool AddClass(AddTheClassModel theClass);
        public bool UpdateClass(UpdateTheClassModel theClass);
        public bool DeleteClass(int theClassId);
        public List<TheClass> GetAll(params Expression<Func<TheClass, object>>[] includeProperties);
        public TheClass GetById(int id, params Expression<Func<TheClass, object>>[] includeProperties);

        public List<TheClass> GetClassWithIncludes(IQueryable<TheClass> classes, params Expression<Func<TheClass, object>>[] includeProperties);



    }
}
