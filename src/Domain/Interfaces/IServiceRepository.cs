using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Slotify.Domain.Entities.ServiceAggreagate;

namespace Slotify.Domain.Interfaces;

public interface IServiceRepository
{
    public Task<ICollection<Service>> GetAllServicesAsync();
    public Task<Service?> GetServiceByIdAsync(Guid id);
    public Task AddServiceAsync(Service service);
    public Task DeleteServiceAsync(Service service);
    public Task SaveChangesAsync();
}