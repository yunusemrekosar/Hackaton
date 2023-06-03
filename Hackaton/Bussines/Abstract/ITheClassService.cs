using Hackaton.Data.Entity;
using Hackaton.Models.Class;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Hackaton.Bussines.Abstract
{
    public interface ITheClassService
    {
        public List<TheClass> GetAllClasses();
        public bool AddClass(AddClassModel theClass);
        public bool UpdateClass(UpdateClassModel theClass);
        public bool DeleteClass(int theClassId);


    }
}
