using HTDPlaces.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HTDPlaces.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public new virtual DbSet<User>? Users { get; set; }
    public virtual DbSet<Event>? Events { get; set; }
    public virtual DbSet<Category>? Categories { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<User>()
            .HasMany(u => u.CreatedEvent)
            .WithOne(e => e.Creator)
            .HasForeignKey("CreatorId");

        builder.Entity<Event>()
            .HasOne(e => e.Creator)
            .WithMany(u => u.CreatedEvent)
            .HasForeignKey("CreatorId");

        builder.Entity<User>()
            .HasMany(u => u.JoinedEvents)
            .WithMany(e => e.Participants);

        builder.Entity<Event>()
            .HasMany(e => e.Participants)
            .WithMany(u => u.JoinedEvents);

        builder.Entity<Event>()
            .HasOne(e => e.Category)
            .WithMany(c => c.Events)
            .HasForeignKey("CategoryId"); // Ajout de la relation avec Category
    }
}
