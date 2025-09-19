using Microsoft.EntityFrameworkCore;
using Slotify.Domain.Entities.ServiceAggreagate;
using Slotify.Domain.Interfaces;
using Slotify.Infrastructure.Database.Context;

namespace Slotify.Infrastructure.Domain
{
    public class ServiceRepository(SlotifyDbContext dbContext) : IServiceRepository
    {
        public async Task<ICollection<Service>> GetAllServicesAsync()
        {
            return await dbContext.Services.ToListAsync();
        }

        public Task<Service?> GetServiceByIdAsync(Guid id)
        {
            return dbContext.Services.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task AddServiceAsync(Service service)
        {
            await dbContext.Services.AddAsync(service);
            await SaveChangesAsync();
        }

        public async Task<Guid> DeleteServiceAsync(Guid id)
        {
            await dbContext.Services.Where(s => s.Id == id).ExecuteDeleteAsync();
            await SaveChangesAsync();
            return id;
        }
        
        public Task SaveChangesAsync() => dbContext.SaveChangesAsync();
        
    }
}