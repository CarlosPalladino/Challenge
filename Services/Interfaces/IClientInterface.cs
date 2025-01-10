using Contract.Dto.Response;
using Contracts.Dto.Request;
using Dtos.ClientDto;

namespace Service.Interfaces
{
    public interface IClientInterface
    {
        Task<List<ClientResponse>> GetAllClients();
        Task<ClientResponse> GetClientById(int Id);
        Task<ClientResponse> SearchClient(string Name);
        Task<ClientDto> InsertClient(ClientRequest request);
        Task<ClientDto> UpdateClient(ClientDto request);
        Task DeleteClient(int Id);
    }
}
