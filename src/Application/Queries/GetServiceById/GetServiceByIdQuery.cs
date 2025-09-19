using MediatR;

namespace Slotify.Application.Queries.GetServiceById;

public class GetServiceByIdQuery : IRequest<GetServiceByIdResponse>
{
    public Guid Id { get; init; }
    public GetServiceByIdQuery(Guid Id)
    {
        this.Id = Id;
    }
}
