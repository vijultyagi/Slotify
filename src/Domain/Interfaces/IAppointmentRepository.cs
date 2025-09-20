using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slotify.Domain.Entities.AppointmentAggregate;

namespace Slotify.Domain.Interfaces
{
    public interface IAppointmentRepository
    {
        public Task<ICollection<Appointment>> GetAllAppointmentsAsync();
        public Task<Appointment?> GetAppointmentByIdAsync(Guid id);
        public Task AddAppointmentAsync(Appointment appointment);
        public Task<Guid> DeleteAppointmentAsync(Guid id);
    }
}