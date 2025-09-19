using Microsoft.EntityFrameworkCore;
using Slotify.Domain.Entities.AppointmentAggregate;
using Slotify.Domain.Entities.ServiceAggreagate;
using Slotify.Domain.Entities.StylistAggregate;

namespace Slotify.Infrastructure.Database.Context;

public class SlotifyDbContext : DbContext
{
    public SlotifyDbContext(DbContextOptions<SlotifyDbContext> options)
        : base(options) { }

    public DbSet<Service> Services { get; set; }
    public DbSet<Stylist> Stylists { get; set; }
    public DbSet<Appointment> Appointments { get; set; }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     base.OnModelCreating(modelBuilder);
    // }
}