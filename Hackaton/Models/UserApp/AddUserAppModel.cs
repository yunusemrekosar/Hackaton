namespace Hackaton.Models.AddUserModel
{
    public class AddUserAppModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        public int DepartmentId { get; set; }

    }
}
