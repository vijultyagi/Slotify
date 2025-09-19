using Slotify.Application.Configuration.Commands;

namespace Slotify.Application.Commands.DeleteService;

public class DeleteServiceCommand(Guid id) : CommandBase<Guid>
{
    public Guid Id { get; } = id;
}
