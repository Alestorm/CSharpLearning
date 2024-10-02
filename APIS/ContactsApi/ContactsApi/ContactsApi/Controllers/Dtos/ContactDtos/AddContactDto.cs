namespace ContactsApi.Controllers.Dtos.ContactDtos
{
    public class AddContactDto
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Company { get; set; }
        public string JobTitle { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Notes { get; set; }
        public int IdUser { get; set; }
    }
}
