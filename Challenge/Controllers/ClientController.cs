using Contracts.Dto.Request;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Swashbuckle.AspNetCore.Annotations;

[Route("[controller]")]
[ApiController]
[SwaggerTag("Endpoints to manage Clients")]
public class ClientController : ControllerBase
{
    private readonly IClientInterface _service;

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

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetClientById(int Id)
    {
        var getClientById = await _service.GetClientById(Id);
        return Ok(getClientById);
    }

    [HttpPost]
    public async Task<IActionResult> CreateClient([FromBody] ClientRequest request)
    {
        var newClient = await _service.InsertClient(request);
        return Ok("New client created");
    }

    [HttpPut]
    public async Task<IActionResult> UpdateClient([FromBody] ClientRequest request)
    {
        var updateClient = await _service.UpdateClient(request);
        return Ok("Client's information updated");
    }

    [HttpDelete("{Id}")]
    public async Task<IActionResult> DeleteClient(int Id)
    {
        await _service.DeleteClient(Id);
        return Ok("The client was deleted successfully");
    }
}
