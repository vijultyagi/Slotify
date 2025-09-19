using MediatR;
using Slotify.Domain.Interfaces;

namespace Slotify.Application.Commands.UpdateService;

public class UpdateServiceHandler(IServiceRepository _serviceRepository) : IRequestHandler<UpdateServiceCommand, Guid>
{
    public async Task<Guid> Handle(UpdateServiceCommand command, CancellationToken cancellationToken)
    {
        var request = command.UpdateServiceRequest;
        var service = await _serviceRepository.GetServiceByIdAsync(command.Id);

        if (service is null)
        {
            throw new InvalidOperationException("Service not found");
        }

        service.Update(request.Name, request.Duration, request.Price, request.Image);
        await _serviceRepository.SaveChangesAsync();

        return service.Id;
    }
}
