using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

namespace Challenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [SwaggerTag("Endpoints to manage Clients")]
    public class ClientController : Controller
    {
        private readonly IClientInterface _service;
        private readonly Mapper _map;
        public ClientController(IClientInterface service, Mapper mapper)
        {
            _map = mapper;
            _service = service;
        }



        [HttpGet]
        public async Task GetAllClient()
        {
            //var getClients =
        }
        [HttpGet]
        public async Task GetClientById(int Id)
        {

        }
        [HttpPost]
        public async Task CreateClient()
        {

        }
        [HttpPut]
        public async Task UpdateClient()
        {

        }
        [HttpDelete]
        public async Task DeleteClient(int Id)
        {

        }
    }
}
