using ClientAccountApi.Domain.Models;

namespace ClientAccountApi.Domain.Contracts
{
    public interface IClient
    {
        Result<Client> AddClient(Client client);
        Result<Client> GetClient(int idClient);
        Result<List<Client>> SearchClient(string query);
        Result<List<Client>> GetClients();
    }
}