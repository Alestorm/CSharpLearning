using ClientAccountApi.Domain.Contracts;
using ClientAccountApi.Domain.Models;
using ClientAccountApi.Infrastructure.MySqlDatabase;

namespace ClientAccountApi.Infrastructure.Repositories
{
    public class ClientRepository : IClient
    {
        private readonly MySqlDbContext _context;
        public ClientRepository(MySqlDbContext context)
        {
            _context = context;
        }

        public Result<Client> AddClient(Client client)
        {
            if (_context.Clients.Any(c => c.Name.Equals(client.Name) || c.Lastname.Equals(client.Lastname) || c.IdNumber == client.IdNumber))
            {
                return Result<Client>.Failure("Client already exists");
            }
            _context.Clients.Add(client);
            _context.SaveChanges();
            return Result<Client>.Success(client);
        }

        public Result<Client> GetClient(int idClient)
        {
            var client = _context.Clients.FirstOrDefault(c => c.IdClient == idClient);
            if (client == null)
            {
                return Result<Client>.Failure("Client not found");
            }
            return Result<Client>.Success(client);
        }

        public Result<List<Client>> GetClients()
        {
            var clients = _context.Clients.ToList();
            return Result<List<Client>>.Success(clients);
        }

        public Result<List<Client>> SearchClient(string query)
        {
            query = query.ToLower();
            var clients = _context.Clients.Where(c => c.Name.ToLower().Contains(query) || c.Lastname.ToLower().Contains(query) || c.IdNumber.ToLower().Contains(query)).ToList();
            return Result<List<Client>>.Success(clients);
        }
    }
}