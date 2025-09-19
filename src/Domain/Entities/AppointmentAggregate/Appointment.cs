using Slotify.Domain.Entities.StylistAggregate;
using Slotify.Domain.Entities.ServiceAggreagate;
using Slotify.Domain.Entities.AppointmentAggregate.Enums;


namespace Slotify.Domain.Entities.AppointmentAggregate;

public class Appointment : BaseEntity
{
    public Guid CustomerId { get; private set; }
    public Guid StylistId { get; private set; }
    public Guid ServiceId { get; private set; }
    public DateTime StartTime { get; private set; }
    public DateTime EndTime { get; private set; }
    public AppointmentStatus Status { get; private set; }

    // Navigation properties (optional)
    public Stylist Stylist { get; private set; }
    public Service Service { get; private set; }
    
    private Appointment() { } // For EF Core

    public Appointment(Guid customerId, Guid stylistId, Guid serviceId, DateTime startTime, DateTime endTime, AppointmentStatus status)
    {
        CustomerId = customerId;
        StylistId = stylistId;
        ServiceId = serviceId;
        StartTime = startTime;
        EndTime = endTime;

        Id = Guid.NewGuid();
        Status = AppointmentStatus.Confirmed;
        CreatedOn = DateTime.UtcNow;
        UpdatedOn = DateTime.UtcNow;

        //TODO: Update these
        CreatedBy = null;
        UpdatedBy = null;
    }

    public void Update(DateTime startTime, DateTime endTime, AppointmentStatus status)
    {
        StartTime = startTime;
        EndTime = endTime;
        Status = status;
    }
}
