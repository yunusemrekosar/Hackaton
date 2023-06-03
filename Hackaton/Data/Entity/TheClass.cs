using Hackaton.Data.Entity.Common;

namespace Hackaton.Data.Entity
{
    public class TheClass: BaseClass
    {


        public List<UserApp> Users { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }
    }
}
