namespace Hackaton.Models.ClassDate
{
    public class UpdateClassDateModel
    {
        public int Id { get; set; }

        public int Day { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public int TheClassId { get; set; }
    }
}
