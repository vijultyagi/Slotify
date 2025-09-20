using Slotify.Application.Configuration.Commands;
using Slotify.Domain.Entities.AppointmentAggregate;
using Slotify.Domain.Entities.AppointmentAggregate.Enums;
using Slotify.Domain.Entities.ServiceAggreagate;
using Slotify.Domain.Interfaces;

namespace Slotify.Application.Commands.CreateAppointment
{
    public class CreateAppointmentHandler(IAppointmentRepository _AppointmentRepository) : ICommandHandler<CreateAppointmentCommand, Guid>
    {
        public async Task<Guid> Handle(CreateAppointmentCommand command, CancellationToken cancellationToken)
        {
            var request = command.CreateAppointmentRequest;

            var newAppointment = new Appointment(request.customerId, request.StartTime, request.EndTime, request.stylist, request.service);

            await _AppointmentRepository.AddAppointmentAsync(newAppointment);

            return await Task.FromResult(newAppointment.Id);
        }
    }
}