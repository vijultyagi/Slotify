using Slotify.Domain.Entities.ServiceAggreagate;
using Slotify.Domain.Entities.StylistAggregate.Enums;

namespace Slotify.Domain.Entities.StylistAggregate;

public class Stylist : BaseEntity
{
    public string Name { get; private set; }
    public string Email { get; private set; }
    public double Availability { get; private set; }
    public ICollection<Service> Services { get; private set; }
    public StylistStatus Status { get; private set; }
    public ICollection<Weekday> DaysOff { get; private set; }

    private Stylist() { } // For EF Core
 
    public Stylist(string name, string email, double availability, ICollection<Service> services, ICollection<Weekday> daysOff)
    {
        Name = name;
        Email = email;
        Availability = availability;
        Services = services;
        DaysOff = daysOff;

        Id = Guid.NewGuid();
        Status = StylistStatus.Active;
        CreatedOn = DateTime.UtcNow;
        UpdatedOn = DateTime.UtcNow;

        //TODO: Update these
        CreatedBy = null;
        UpdatedBy = null;
    }

    public void Update(string name, string email, double availability, ICollection<Service> services, StylistStatus status, ICollection<Weekday> daysOff)
    {
        Name = name;
        Email = email;
        Availability = availability;
        Services = services;
        Status = status;
        DaysOff = daysOff;
    }
}