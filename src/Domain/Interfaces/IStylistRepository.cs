using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slotify.Domain.Entities.StylistAggregate;

namespace Domain.Interfaces
{
    public interface IStylistRepository
    {
        public Task<ICollection<Stylist>> GetAllStylistsAsync();
        public Task<Stylist?> GetStylistByIdAsync(Guid id);
        public Task AddStylistAsync(Stylist stylist);
        public Task UpdateStylistAsync(Stylist stylist);
        public Task DeleteStylistAsync(Stylist stylist);
    }
}