using AutoMapper;
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
            CreateMap<ClientRequest, Client>();
        }
    }
}
