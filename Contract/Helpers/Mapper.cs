using AutoMapper;
using Contract.Dto.Response;
using Contracts.Dto.Request;
using Data.Entitie;
using Dtos.ClientDto;

namespace Contract.Helpers
{
    public class Mapper : Profile
    {

        public Mapper()
        {
            CreateMap<Client, ClientDto>();
            CreateMap<ClientDto, Client>();
            CreateMap<Client, ClientResponse>();
            CreateMap<ClientRequest, Client>();
        }
    }
}
