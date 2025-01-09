using AutoMapper;
using Contracts.Dto.Request;
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
        public ClientController(IClientInterface service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllClient()
        {
            var getClients = await _service.GetAllClients();

            return Ok(getClients);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetClientById(int Id)
        {
            var getClientById = await _service.GetClientById(Id);
            return Ok(GetClientById);
        }
        [HttpPost]
        public async Task<IActionResult> CreateClient(ClientRequest request)
        {
            var newClient =  await _service.InsertClient(request);

            return Ok("New client");
        }
        //[HttpPut]
        //public async Task<IActionResult> UpdateClient(ClientRequest request)
        //{
        //    var updateClient =await  _service.UpdateClient(request);
        //    return Ok("Client's information changed");

        //}
        //[HttpDelete]
        //public async Task<IActionResult> DeleteClient(long dni)
        //{
        //    var deleteClient = await _service.DeleteClient(dni);
        //    return Ok("the cliente was deleted succesfully");
        //}
    }
}
