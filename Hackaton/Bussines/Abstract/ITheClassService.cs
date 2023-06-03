using Hackaton.Data.Entity;
using Hackaton.Models.TheClass;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Hackaton.Bussines.Abstract
{
    public interface ITheClassService
    {
        public List<TheClass> GetAllClasses();
        public bool AddClass(AddTheClassModel theClass);
        public bool UpdateClass(UpdateTheClassModel theClass);
        public bool DeleteClass(int theClassId);


    }
}
