using Hackaton.Data.Entity.Common;

namespace Hackaton.Data.Entity
{
    public class Department: BaseClass
    {
        public string Name { get; set; }

        public List<TheClass> Classes { get; set; }
    }
}
