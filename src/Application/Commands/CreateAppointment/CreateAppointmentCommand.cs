using Slotify.Application.Configuration.Commands;

namespace Slotify.Application.Commands.CreateAppointment;

public class CreateAppointmentCommand(CreateAppointmentRequest createAppointmentRequest) : CommandBase<Guid>
{
    public CreateAppointmentRequest CreateAppointmentRequest { get; } = createAppointmentRequest;
}