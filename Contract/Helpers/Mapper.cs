using AutoMapper;
using Data.Entitie;
using Dtos.ClientDto;

namespace Contract.Helpers
{
    public class Mapper : Profile
    {

        public Mapper()
        {
            CreateMap<Client, ClientDto>();
        }
    }
}
