namespace Slotify.Application.Queries.GetServiceById;

public record GetServiceByIdResponse(
    Guid Id,
    string Name,
    float Duration,
    double Price,
    string? Image
);
