namespace ClientAccountApi.Domain.Models
{
    public class Account
    {
        public int IdAccount { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreationDate { get; set; }
        public decimal Interest { get; set; }
        public int Type { get; set; }
        public int IdClient { get; set; }
        public Client Client { get; set; }
    }
}
