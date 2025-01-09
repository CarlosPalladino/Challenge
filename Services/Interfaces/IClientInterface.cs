using Contracts.Dto.Request;
using Dtos.ClientDto;

namespace Service.Interfaces
{
    public interface IClientInterface
    {
        Task<List<ClientDto>> GetAllClients();
        Task<ClientDto> GetClientById(int Id);
        Task<ClientDto> SearchClient(string Name);
        Task<ClientDto> InsertClient(ClientRequest request);
        Task<ClientDto> UpdateClient(ClientDto request);
        Task DeleteClient(int Id);
    }
}
