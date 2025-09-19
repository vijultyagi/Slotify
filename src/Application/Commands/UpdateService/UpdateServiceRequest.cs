namespace Slotify.Application.Commands.UpdateService;

public record UpdateServiceRequest(
    string Name,
    float Duration,
    double Price,
    string? Image
);
