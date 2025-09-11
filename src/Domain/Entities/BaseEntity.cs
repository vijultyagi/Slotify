namespace Slotify.Domain.Entities;

public class BaseEntity
{
    public Guid Id {get; protected set;}
    public DateTime CreatedOn {get; protected set;}
    public Guid? CreatedBy {get; protected set;}
    public DateTime? UpdatedOn {get; protected set;}
    public Guid? UpdatedBy {get; protected set;}
}