using Slotify.Application.Configuration.Commands;

namespace Slotify.Application.Commands.CreateService;

public class CreateServiceCommand(CreateServiceRequest createServiceRequest) : CommandBase<Guid>
{
    public CreateServiceRequest CreateServiceRequest { get; } = createServiceRequest;
}