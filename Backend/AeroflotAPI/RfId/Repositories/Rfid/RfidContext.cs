using AeroflotAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AeroflotAPI.Repositories;

public class RfidContext : DbContext
{
    public RfidContext(DbContextOptions<RfidContext> options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    public DbSet<Equip> Equips { get; set; }
    public DbSet<Zone> Zones { get; set; }
    public DbSet<People> People { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Equip>()
            .HasIndex(p => new { p.RfId })
            .IsUnique();
        modelBuilder.Entity<Zone>()
            .HasIndex(p => new { p.Id })
            .IsUnique();
        modelBuilder.Entity<People>()
            .HasIndex(p => new { p.Id })
            .IsUnique();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost; Port=5432;Database=AeroflotRfid;User Id=postgres;Password=root");
    }
}