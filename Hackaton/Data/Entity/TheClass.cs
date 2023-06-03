using Hackaton.Data.Entity.Common;

namespace Hackaton.Data.Entity
{
    public class TheClass: BaseClass
    {
        public string Name { get; set; }

        public List<UserApp> Users { get; set; }
        public List<ClassDate> ClassDates { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }
    }
}
