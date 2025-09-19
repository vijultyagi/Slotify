using MediatR;
using Microsoft.AspNetCore.Mvc;
using Slotify.Application.Commands.CreateService;
using Slotify.Application.Commands.DeleteService;
using Slotify.Application.Commands.UpdateService;
using Slotify.Application.Queries.GetServiceById;
using Slotify.Application.Queries.GetServices;

namespace Slotify.Api.Controllers;

[ApiController]
[Route("api/services")]
public class ServiceController(IMediator _mediatr) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetServices()
    {
        var result = await _mediatr.Send(new GetServicesQuery());
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetServiceById(Guid id)
    {
        var result = await _mediatr.Send(new GetServiceByIdQuery(id));
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateService(CreateServiceRequest request)
    {
        var result = await _mediatr.Send(new CreateServiceCommand(request));
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateService(Guid id, UpdateServiceRequest request)
    {
        var result = await _mediatr.Send(new UpdateServiceCommand(id, request));
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteService(Guid id)
    {
        var result = await _mediatr.Send(new DeleteServiceCommand(id));
        return Ok(result);
    }
}