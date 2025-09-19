using Slotify.Application.Configuration.Commands;
using Slotify.Domain.Entities.ServiceAggreagate;
using Slotify.Domain.Interfaces;

namespace Slotify.Application.Commands.CreateService
{
    public class CreateServiceHandler(IServiceRepository _serviceRepository) : ICommandHandler<CreateServiceCommand, Guid>
    {
        public async Task<Guid> Handle(CreateServiceCommand command, CancellationToken cancellationToken)
        {
            var request = command.CreateServiceRequest;

            var newService = new Service(request.Name, request.Duration, request.Price, request.Image);

            await _serviceRepository.AddServiceAsync(newService);

            return await Task.FromResult(newService.Id);
        }
    }
}