using AutoMapper;
using Contracts.Dto.Request;
using Data.Context;
using Data.Entitie;
using Dtos.ClientDto;
using Microsoft.EntityFrameworkCore;
using Service.Interfaces;

namespace Service.Repository
{
    public class ClientRepository : IClientInterface
    {
        private readonly ChallengeContext _context;
        private readonly Mapper _mapper;
        public ClientRepository(ChallengeContext contex, Mapper mapper)
        {
            _context = contex;
            _mapper = mapper;
        }
        public async Task<List<ClientDto>> GetAllClients()
        {
            var clients = await _context.Clients.ToListAsync();

            return _mapper.Map<List<ClientDto>>(clients);

        }

        public async Task<ClientDto> GetClientById(int id)
        {
            var client = await _context.Clients
                .Where(c => c.Id.Equals(id))
                .ToListAsync();
            return _mapper.Map<ClientDto>(client);

        }
        private async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        private async Task<bool> ClientExistAsync(int dni)
        {
            return await _context.Clients.AnyAsync(c => c.Dni == dni);
        }

        public async Task<ClientDto> InsertClient(ClientRequest request)
        {
            var newClient = _mapper.Map<Client>(request);
            await _context.Clients.AddAsync(newClient);
            await SaveChangesAsync();
            return _mapper.Map<ClientDto>(newClient);
        }

        public async Task<ClientDto> UpdateClient(int id, ClientDto clientDto)
        {
            var existingClient = await _context.Clients.FindAsync(id);
            if (existingClient == null)
                throw new Exception("Client not found");

            _mapper.Map(clientDto, existingClient);
            await SaveChangesAsync();
            return _mapper.Map<ClientDto>(existingClient);
        }

        public async Task DeleteClient(int dni)
        {
            if (!await ClientExistAsync(dni))
                throw new Exception("Client not found");

            var clientToDelete = await _context.Clients.FirstOrDefaultAsync(c => c.Dni == dni);
            _context.Clients.Remove(clientToDelete);
            await SaveChangesAsync();
        }

    }
}
