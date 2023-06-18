using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RndTech.SalariesMonitoring.Database.Models;

namespace RndTech.SalariesMonitoring.Database.ModelConfiguration;

public class SalaryMonitoringRequestRegionEntityTypeConfiguration
	: IEntityTypeConfiguration<SalaryMonitoringRequestRegion>
{
	public void Configure(EntityTypeBuilder<SalaryMonitoringRequestRegion> builder)
	{
		builder.ToTable("salary_monitoring_request_region");
		builder.Property(x => x.Id).HasColumnName("id");
		builder.Property(x => x.Name).HasColumnName("name");
		builder.Property(x => x.ExternalId).HasColumnName("external_id");
		builder.Property(x => x.RequestId).HasColumnName("request_id");
		
		builder.HasKey(e => e.Id);
		builder.Property(e => e.Name).IsRequired();
		builder.Property(e => e.ExternalId).IsRequired();
		builder.Property(e => e.RequestId).IsRequired();

		builder
			.HasOne(e => e.Request)
			.WithMany(e => e.Regions)
			.HasForeignKey(e => e.RequestId);
	}
}