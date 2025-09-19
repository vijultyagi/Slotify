using Slotify.Application.Configuration.Commands;

namespace Slotify.Application.Commands.UpdateService;

public class UpdateServiceCommand(UpdateServiceRequest updateServiceRequest) : CommandBase<Guid>
{
    public UpdateServiceRequest UpdateServiceRequest { get; } = updateServiceRequest;
}
