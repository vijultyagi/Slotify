using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Slotify.Domain.Entities.ServiceAggreagate;

namespace Slotify.Infrastructure.Domain
{
    public class ServiceRepository : IServiceRepository
    {
        public Task<ICollection<Service>> GetAllServicesAsync()
        {
            throw new NotImplementedException();
        }
        public Task<Service?> GetServiceByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
        public Task AddServiceAsync(Service service)
        {
            throw new NotImplementedException();
        }

        public Task UpdateServiceAsync(Service service)
        {
            throw new NotImplementedException();
        }
        
        public Task DeleteServiceAsync(Service service)
        {
            throw new NotImplementedException();
        }
        
    }
}