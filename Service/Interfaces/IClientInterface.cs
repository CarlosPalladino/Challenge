using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public interface IClientInterface
    {
        Task<List<ClientDto>> GetAllClients();
        Task<ClientDto> GetClientById(int id);
        Task<List<ClientDto>> SearchClients(string name);
        Task<ClientDto> InsertClient(ClientDto clientDto);
        Task<ClientDto> UpdateClient(int id, ClientDto clientDto);
    }
}
