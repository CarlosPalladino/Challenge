using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Challenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [SwaggerTag("Endpoints to manage Clients")]
    public class ClientController : Controller
    {
        [HttpGet]
        public async Task GetAllClient()
        {

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
