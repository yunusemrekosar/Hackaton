namespace Hackaton.Data.Entity.Common
{
    public class BaseClass
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }         
        public DateTime UpdatedOn { get; set; }
        public bool IsActive { get; set; }

    }
}
