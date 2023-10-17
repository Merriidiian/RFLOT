using AeroflotAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AeroflotAPI.Repositories;

public class ReportContext : DbContext
{
    public ReportContext(DbContextOptions<ReportContext> options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    public DbSet<ReportZone> ReportZones { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ReportZone>()
            .HasIndex(p => new { p.IdReportZone })
            .IsUnique();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost; Port=5432;Database=AeroflotRfid;User Id=postgres;Password=root");
    }
}