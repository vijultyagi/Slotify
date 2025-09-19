using MediatR;

namespace Slotify.Application.Queries.GetServices;

public class GetServicesQuery : IRequest<IEnumerable<GetServicesResponse>>
{
    public GetServicesQuery() { }
}
