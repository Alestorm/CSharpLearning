namespace ClientAccountApi.Controllers.Dtos.AccountDtos
{
    public class NewAccountDto
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public decimal Interest { get; set; }
        public int Type { get; set; }
        public int IdClient { get; set; }
    }
}
