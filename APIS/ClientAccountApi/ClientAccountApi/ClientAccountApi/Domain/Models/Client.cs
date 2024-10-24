namespace ClientAccountApi.Domain.Models
{
    public class Client
    {
        public int IdClient { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string IdNumber { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<Account> Accounts { get; set; }
    }
}
