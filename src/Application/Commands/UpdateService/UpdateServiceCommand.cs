using Slotify.Application.Configuration.Commands;

namespace Slotify.Application.Commands.UpdateService;

public class UpdateServiceCommand(Guid id, UpdateServiceRequest updateServiceRequest) : CommandBase<Guid>
{
    public UpdateServiceRequest UpdateServiceRequest { get; } = updateServiceRequest;
    public Guid Id { get; } = id;
}
