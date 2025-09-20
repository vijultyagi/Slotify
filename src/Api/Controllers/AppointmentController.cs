using MediatR;
using Microsoft.AspNetCore.Mvc;
using Slotify.Application.Commands.CreateAppointment;

namespace Slotify.Api.Controllers;

[ApiController]
[Route("api/appointments")]
public class AppointmentController(IMediator _mediatr) : ControllerBase
{
    // [HttpGet]
    // public async Task<IActionResult> GetAppointments()
    // {
    //     var result = await _mediatr.Send(new GetAppointmentsQuery());
    //     return Ok(result);
    // }

    // [HttpGet("{id}")]
    // public async Task<IActionResult> GetAppointmentById(Guid id)
    // {
    //     var result = await _mediatr.Send(new GetAppointmentByIdQuery(id));
    //     return Ok(result);
    // }

    [HttpPost]
    public async Task<IActionResult> CreateAppointment(CreateAppointmentRequest request)
    {
        var result = await _mediatr.Send(new CreateAppointmentCommand(request));
        return Ok(result);
    }

    // [HttpPut("{id}")]
    // public async Task<IActionResult> UpdateAppointment(Guid id, UpdateAppointmentRequest request)
    // {
    //     var result = await _mediatr.Send(new UpdateAppointmentCommand(id, request));
    //     return Ok(result);
    // }

    // [HttpDelete("{id}")]
    // public async Task<IActionResult> DeleteAppointment(Guid id)
    // {
    //     var result = await _mediatr.Send(new DeleteAppointmentCommand(id));
    //     return Ok(result);
    // }
}