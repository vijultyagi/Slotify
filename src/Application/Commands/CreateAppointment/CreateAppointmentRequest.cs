using Slotify.Domain.Entities.ServiceAggreagate;
using Slotify.Domain.Entities.StylistAggregate;

namespace Slotify.Application.Commands.CreateAppointment;

public record CreateAppointmentRequest(Guid customerId, DateTime StartTime, DateTime EndTime, Service service, Stylist stylist);