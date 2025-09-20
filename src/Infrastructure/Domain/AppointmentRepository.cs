using Microsoft.EntityFrameworkCore;
using Slotify.Domain.Entities.AppointmentAggregate;
using Slotify.Domain.Interfaces;
using Slotify.Infrastructure.Database.Context;

namespace Slotify.Infrastructure.Domain
{
    public class AppointmentRepository(SlotifyDbContext dbContext) : IAppointmentRepository
    {
        public async Task<ICollection<Appointment>> GetAllAppointmentsAsync()
        {
            return await dbContext.Appointments.ToListAsync();
        }

        public Task<Appointment?> GetAppointmentByIdAsync(Guid id)
        {
            return dbContext.Appointments.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task AddAppointmentAsync(Appointment appointment)
        {
            await dbContext.Appointments.AddAsync(appointment);
            await SaveChangesAsync();
        }

        public async Task<Guid> DeleteAppointmentAsync(Guid id)
        {
            await dbContext.Appointments.Where(s => s.Id == id).ExecuteDeleteAsync();
            await SaveChangesAsync();
            return id;
        }
        
        public Task SaveChangesAsync() => dbContext.SaveChangesAsync();
        
    }
}