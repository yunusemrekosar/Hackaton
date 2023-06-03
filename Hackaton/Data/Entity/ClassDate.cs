namespace Hackaton.Data.Entity
{
    public class ClassDate
    {
        public int Day { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public int TheClassId { get; set; }
        public TheClass TheClass { get; set; }
    }
}
