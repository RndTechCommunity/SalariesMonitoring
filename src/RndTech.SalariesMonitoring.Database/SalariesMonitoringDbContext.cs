using Microsoft.EntityFrameworkCore;

namespace RndTech.SalariesMonitoring.Database;

public class SalariesMonitoringDbContext : DbContext
{
    public SalariesMonitoringDbContext(DbContextOptions options) 
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SalariesMonitoringDbContext).Assembly);
    }

}