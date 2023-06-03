using Hackaton.Data.Entity;
using Hackaton.Models.Class;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Hackaton.Bussines.Abstract
{
    public interface ITheClassService
    {
        public List<TheClass> GetAllClasses();
        public bool AddClass(AddClassModel theClass);
        public bool UpdateClass(AddClassModel TheClass);
        public bool DeleteClass(AddClassModel TheClass);


    }
}
