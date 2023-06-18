using Microsoft.EntityFrameworkCore;
using RndTech.SalariesMonitoring.Database.Models;

namespace RndTech.SalariesMonitoring.Database;

public class SalariesMonitoringDbContext : DbContext
{
	public DbSet<SalaryMonitoringRequest> SalaryMonitoringRequests { get; set; }
	public DbSet<SalaryMonitoringRequestRegion> SalaryMonitoringRequestsRegions { get; set; }
	public DbSet<SalaryMonitoringRequestJobTitle> SalaryMonitoringRequestJobTitles { get; set; }
	public DbSet<SalaryMonitoringRequestVacancy> SalaryMonitoringRequestVacancies { get; set; }

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