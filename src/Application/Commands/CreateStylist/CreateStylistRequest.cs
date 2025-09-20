using Slotify.Domain.Entities.ServiceAggreagate;
using Slotify.Domain.Entities.StylistAggregate.Enums;

namespace Slotify.Application.Commands.CreateStylist;

public record CreateStylistRequest(
    string Name,
    string Email,
    double Availability,
    IEnumerable<Service> Services,
    IEnumerable<Weekday> DaysOff);