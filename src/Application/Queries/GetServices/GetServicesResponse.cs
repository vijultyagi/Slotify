namespace Slotify.Application.Queries.GetServices;

public record GetServicesResponse(
    Guid Id,
    string Name,
    float Duration,
    double Price,
    string? Image
);
