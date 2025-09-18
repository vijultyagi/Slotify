using Slotify.Application.Configuration.Commands;
using MediatR;
using Slotify.Domain.Entities.ServiceAggreagate;

namespace Slotify.Application.Commands.CreateService
{
    public class CreateServiceHandler : ICommandHandler<CreateServiceCommand, Guid>
    {
        public async Task<Guid> Handle(CreateServiceCommand command, CancellationToken cancellationToken)
        {
            var request = command.CreateServiceRequest;
            var newService = new Service(request.Name, request.duration, request.Price, request.Image);

            return await Task.FromResult(newService.Id);
        }
        
    }
}