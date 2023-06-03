namespace Hackaton.Models.User
{
    public class UpdateUserAppModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public int DepartmentId { get; set; }
    }
}
