using Hackaton.Data.Entity.Common;

namespace Hackaton.Data.Entity
{
    public class ClassDate: BaseClass
    {
        public int Day { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public int TheClassId { get; set; }
        public TheClass TheClass { get; set; }
    }
}
