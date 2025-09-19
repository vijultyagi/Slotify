namespace Slotify.Application.Commands.UpdateService;

public record UpdateServiceRequest(
    Guid Id,
    string Name,
    float Duration,
    double Price,
    string? Image
);
