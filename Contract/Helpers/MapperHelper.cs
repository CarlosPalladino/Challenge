using AutoMapper;
using Data.Entitie;
using Dtos.ClientDto;

namespace Contract.Helpers
{
    public class MapperHelper : Profile
    {
        public MapperHelper()
        {
            CreateMap<Client, ClientDto>();


        }
    }
}
