using MediatR;
using Slotify.Domain.Interfaces;

namespace Slotify.Application.Queries.GetServices;

public class GetServicesHandler(IServiceRepository _serviceRepository) : IRequestHandler<GetServicesQuery, IEnumerable<GetServicesResponse>>
{
    public async Task<IEnumerable<GetServicesResponse>> Handle(GetServicesQuery request, CancellationToken cancellationToken)
    {
        var services = await _serviceRepository.GetAllServicesAsync();

        return services.Select(service => new GetServicesResponse(
            service.Id,
            service.Name,
            service.Duration,
            service.Price,
            service.Image));
    }
}
