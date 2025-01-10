using AutoMapper;
using Contracts.Dto.Request;
using Contracts.Exceptions;
using Data.Context;
using Data.Entitie;
using Dtos.ClientDto;
using Microsoft.EntityFrameworkCore;
using Service.Interfaces;

public class ClientRepository : IClientInterface
{
    private readonly ChallengeContext _context;
    private readonly IMapper _mapper;

    public ClientRepository(ChallengeContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    public async Task<List<ClientDto>> GetAllClients()
    {
        var clients = await _context.Clients.ToListAsync();
        return _mapper.Map<List<ClientDto>>(clients);
    }
    public async Task<ClientDto> InsertClient(ClientRequest request)
    {
        if (await ClientExists(request.Dni))
            throw new BadRequestException("400 Bad Request", $"Client with DNI {request.Dni} already exists.");

        var newClient = _mapper.Map<Client>(request);
        await _context.Clients.AddAsync(newClient);
        await _context.SaveChangesAsync();
        return _mapper.Map<ClientDto>(newClient);
    }

    public async Task<ClientDto> UpdateClient(ClientDto request)
    {
        var existingClient = await _context.Clients.FirstOrDefaultAsync(c => c.Email.Equals(request.Email));
        if (existingClient == null)
            throw new BadRequestException("400 Bad Request", $"Client with email {request.Email} not found.");

        _mapper.Map(request, existingClient);
        _context.Clients.Update(existingClient);
        await _context.SaveChangesAsync();

        return _mapper.Map<ClientDto>(existingClient);
    }

    public async Task DeleteClient(int Id)
    {
        var clientToDelete = await _context.Clients.FirstOrDefaultAsync(c => c.Id == Id);

        if (clientToDelete == null)
            throw new BadRequestException("400 Bad Request", $"Client with ID {Id} not found.");

        _context.Clients.Remove(clientToDelete);
        await _context.SaveChangesAsync();
    }

    public async Task<ClientDto> SearchClient(string Name)
    {

        var searchClient = await _context.Clients
            .Where(c => c.Name.Contains(Name) || c.Name.Equals(Name))
            .FirstOrDefaultAsync();

        if (searchClient == null)
            throw new NotFoundException("404 Not Foud", $"No client found with name {Name}.");

        return _mapper.Map<ClientDto>(searchClient);
    }

    public async Task<ClientDto> GetClientById(int id)
    {
        var client = await _context.Clients
            .FirstOrDefaultAsync(c => c.Id == id);

        if (client == null)
            throw new BadRequestException("400 Bad Request", $"Client with ID {id} not found.");

        return _mapper.Map<ClientDto>(client);
    }

    private async Task<bool> ClientExists(long Dni)
    {
        return await _context.Clients.AnyAsync(c => c.Dni.Equals(Dni));
    }


}
