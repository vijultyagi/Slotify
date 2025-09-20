using Slotify.Application.Configuration.Commands;

namespace Slotify.Application.Commands.CreateStylist;

public class CreateStylistCommand(CreateStylistRequest createStylistRequest) : CommandBase<Guid>
{
    public CreateStylistRequest CreateStylistRequest { get; } = createStylistRequest;
}