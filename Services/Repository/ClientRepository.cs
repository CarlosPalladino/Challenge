﻿using AutoMapper;
using Contracts.Dto.Request;
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

    public async Task<ClientDto> GetClientById(int id)
    {
        var client = await _context.Clients
            .FirstOrDefaultAsync(c => c.Id == id);

        if (client == null)
            throw new KeyNotFoundException($"Client with ID {id} not found.");

        return _mapper.Map<ClientDto>(client);
    }

    public async Task<ClientDto> InsertClient(ClientRequest request)
    {
        if (await ClientExists(request.Dni))
            throw new InvalidOperationException($"Client with DNI {request.Dni} already exists.");

        var newClient = _mapper.Map<Client>(request);
        await _context.Clients.AddAsync(newClient);
        await _context.SaveChangesAsync();
        return _mapper.Map<ClientDto>(newClient);
    }

    public async Task<ClientDto> UpdateClient(ClientRequest request)
    {
        var existingClient = await _context.Clients.FirstOrDefaultAsync(c => c.Dni.Equals(request.Dni));
        if (existingClient == null)
            throw new KeyNotFoundException($"Client with ID {request.Dni} not found.");

        _mapper.Map(request, existingClient);
        _context.Clients.Update(existingClient);
        await _context.SaveChangesAsync();

        return _mapper.Map<ClientDto>(existingClient);
    }

    public async Task DeleteClient(int Id)
    {
        var clientToDelete = await _context.Clients.FirstOrDefaultAsync(c => c.Id == Id);

        if (clientToDelete == null)
            throw new KeyNotFoundException($"Client with ID {Id} not found.");

        _context.Clients.Remove(clientToDelete);
        await _context.SaveChangesAsync();
    }

    private async Task<bool> ClientExists(long Dni)
    {
        return await _context.Clients.AnyAsync(c => c.Dni.Equals(Dni));
    }
}
