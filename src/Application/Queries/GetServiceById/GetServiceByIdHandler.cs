using MediatR;
using Slotify.Domain.Interfaces;

namespace Slotify.Application.Queries.GetServiceById;

public class GetServiceByIdHandler(IServiceRepository _serviceRepository) : IRequestHandler<GetServiceByIdQuery, GetServiceByIdResponse>
{
    public async Task<GetServiceByIdResponse> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
    {
        var service = await _serviceRepository.GetServiceByIdAsync(request.Id);

        return service is null ? throw new InvalidOperationException("Service not found") : new GetServiceByIdResponse(
            service.Id,
            service.Name,
            service.Duration,
            service.Price,
            service.Image);
    }
}
