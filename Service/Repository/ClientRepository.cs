using Service.Interfaces;

namespace Service.Repository
{
    public class ClientRepository : IClientInterface
    {
        private readonly ChallengeContext _context;
        public ClientRepository(ChallengeContext contex)
        {
            _context = contex;
        }
        public async Task<List<ClientDto>> GetAllClients()
        {
            var clients = await _contex;

        }

        public async Task<ClientDto> GetClientById(int id)
        {
            var client = await _context.Client.FirstOrDefaultAsync(c => c.Id == id);
            if (client == null)
                return null;

            return new ClientDto
            {
                Name = client.Name,
                LastName = client.LastName,
                Email = client.Email
            };
        }

        public async Task<List<ClientDto>> SearchClients(string name)
        {
            var clients = await _context.Client
                .Where(c => EF.Functions.Like(c.Name, $"%{name}%"))
                .ToListAsync();

            return clients.Select(c => new ClientDto
            {
                Name = c.Name,
                LastName = c.LastName,
                Email = c.Email
            }).ToList();
        }

        public async Task<ClientDto> InsertClient(ClientDto clientDto)
        {
            var client = new Client
            {
                Name = clientDto.Name,
                LastName = clientDto.LastName,
                Email = clientDto.Email
            };

            _context.Client.Add(client);
            await _context.SaveChangesAsync();

            return clientDto;
        }

        public async Task<ClientDto> UpdateClient(int id, ClientDto clientDto)
        {
            var existingClient = await _context.Client.FirstOrDefaultAsync(c => c.Id == id);
            if (existingClient == null)
                return null;

            existingClient.Name = clientDto.Name;
            existingClient.LastName = clientDto.LastName;
            existingClient.Email = clientDto.Email;

            await _context.SaveChangesAsync();

            return clientDto;
        }
    }
}
