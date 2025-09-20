using Microsoft.EntityFrameworkCore;
using Slotify.Domain.Entities.StylistAggregate;
using Slotify.Domain.Interfaces;
using Slotify.Infrastructure.Database.Context;

namespace Slotify.Infrastructure.Domain
{
    public class StylistRepository(SlotifyDbContext dbContext) : IStylistRepository
    {
        public async Task<ICollection<Stylist>> GetAllStylistsAsync()
        {
            return await dbContext.Stylists.ToListAsync();
        }

        public Task<Stylist?> GetStylistByIdAsync(Guid id)
        {
            return dbContext.Stylists.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task AddStylistAsync(Stylist stylist)
        {
            await dbContext.Stylists.AddAsync(stylist);
            await SaveChangesAsync();
        }

        public async Task<Guid> DeleteStylistAsync(Guid id)
        {
            await dbContext.Stylists.Where(s => s.Id == id).ExecuteDeleteAsync();
            await SaveChangesAsync();
            return id;
        }
        
        public Task SaveChangesAsync() => dbContext.SaveChangesAsync();
        
    }
}