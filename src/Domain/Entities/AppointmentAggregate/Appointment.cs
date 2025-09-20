using Slotify.Domain.Entities.StylistAggregate;
using Slotify.Domain.Entities.ServiceAggreagate;
using Slotify.Domain.Entities.AppointmentAggregate.Enums;


namespace Slotify.Domain.Entities.AppointmentAggregate;

public class Appointment : BaseEntity
{
    public Guid CustomerId { get; private set; }
    public DateTime StartTime { get; private set; }
    public DateTime EndTime { get; private set; }
    public AppointmentStatus Status { get; private set; }
    public Stylist Stylist { get; private set; }
    public Service Service { get; private set; }
    
    private Appointment() { } // For EF Core

    public Appointment(Guid customerId, DateTime startTime, DateTime endTime, Stylist stylist, Service service)
    {
        CustomerId = customerId;
        StartTime = startTime;
        EndTime = endTime;
        Stylist = stylist;
        Service = service;

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
