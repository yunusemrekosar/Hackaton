using Hackaton.Data.Entity;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Hackaton.Bussines.Abstract
{
    public interface ITheClassService
    {
        public List<TheClass> GetAllClasses();
        public bool AddClass(TheClass theClass);
        public bool UpdateClass(TheClass TheClass);
        public bool DeleteClass(TheClass TheClass);


    }
}
