using Slotify.Application.Configuration.Commands;
using Slotify.Domain.Entities.ServiceAggreagate;
using Slotify.Domain.Entities.StylistAggregate;
using Slotify.Domain.Interfaces;

namespace Slotify.Application.Commands.CreateStylist
{
    public class CreateStylistHandler(IStylistRepository _StylistRepository) : ICommandHandler<CreateStylistCommand, Guid>
    {
        public async Task<Guid> Handle(CreateStylistCommand command, CancellationToken cancellationToken)
        {
            var request = command.CreateStylistRequest;

            var newStylist = new Stylist(request.Name, request.Email, request.Availability, request.Services.ToList(), request.DaysOff.ToList());

            await _StylistRepository.AddStylistAsync(newStylist);

            return await Task.FromResult(newStylist.Id);
        }
    }
}