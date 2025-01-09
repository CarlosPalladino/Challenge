using Contracts.Dto.Request;
using Dtos.ClientDto;

namespace Service.Interfaces
{
    public interface IClientInterface
    {
        Task<List<ClientDto>> GetAllClients();
        Task<ClientDto> GetClientById(int id);
        Task<ClientDto> InsertClient(ClientRequest request);
        Task<ClientDto> UpdateClient(int id,ClientDto clientDto);
        Task DeleteClient(int dni);
    }
}
