namespace Slotify.Domain.Entities.ServiceAggreagate;

public class Service : BaseEntity
{
    public string Name { get; private set; }
    public float Duration { get; private set; }
    public double Price { get; private set; }
    public string Image { get; private set; }
    
    private Service() { } // For EF Core

    public Service(string name, float duration, double price, string image)
    {
        Name = name;
        Duration = duration;
        Price = price;
        Image = image;

        Id = Guid.NewGuid();
        CreatedOn = DateTime.UtcNow;
        UpdatedOn = DateTime.UtcNow;

        //TODO: Update these
        CreatedBy = null;
        UpdatedBy = null;
    }

    public void Update(string name, float duration, double price, string image)
    {
        Name = name;
        Duration = duration;
        Price = price;
        Image = image;
    }
}