using MediatR;
using Microsoft.AspNetCore.Mvc;
using Slotify.Application.Commands.CreateStylist;
using Slotify.Application.Commands.UpdateService;
using Slotify.Application.Queries.GetServiceById;
using Slotify.Application.Queries.GetServices;

namespace Slotify.Api.Controllers;

[ApiController]
[Route("api/stylists")]
public class StylistController(IMediator _mediatr) : ControllerBase
{
    // [HttpGet]
    // public async Task<IActionResult> GetStylists()
    // {
    //     var result = await _mediatr.Send(new GetStylistsQuery());
    //     return Ok(result);
    // }

    // [HttpGet("{id}")]
    // public async Task<IActionResult> GetStylistById(Guid id)
    // {
    //     var result = await _mediatr.Send(new GetStylistByIdQuery(id));
    //     return Ok(result);
    // }

    [HttpPost]
    public async Task<IActionResult> CreateStylist(CreateStylistRequest request)
    {
        var result = await _mediatr.Send(new CreateStylistCommand(request));
        return Ok(result);
    }

    // [HttpPut("{id}")]
    // public async Task<IActionResult> UpdateStylist(Guid id, UpdateStylistRequest request)
    // {
    //     var result = await _mediatr.Send(new UpdateStylistCommand(id, request));
    //     return Ok(result);
    // }

    // [HttpDelete("{id}")]
    // public async Task<IActionResult> DeleteStylist(Guid id)
    // {
    //     var result = await _mediatr.Send(new DeleteStylistCommand(id));
    //     return Ok(result);
    // }
}