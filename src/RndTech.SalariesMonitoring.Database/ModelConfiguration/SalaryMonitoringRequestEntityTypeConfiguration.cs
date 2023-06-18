using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RndTech.SalariesMonitoring.Database.Models;

namespace RndTech.SalariesMonitoring.Database.ModelConfiguration;

public class SalaryMonitoringRequestEntityTypeConfiguration
	:IEntityTypeConfiguration<SalaryMonitoringRequest>
{
	public void Configure(EntityTypeBuilder<SalaryMonitoringRequest> builder)
	{
		builder.ToTable("evp_ticket_request");
		builder.Property(x => x.Id).HasColumnName("id");
		builder.Property(x => x.CreatedAt).HasColumnName("created_at");
		builder.Property(x => x.LastUpdatedAt).HasColumnName("last_updated_at");
		builder.Property(x => x.IsEnabled).HasColumnName("is_enabled");

		builder.HasKey(e => e.Id);
		builder.Property(e => e.CreatedAt).IsRequired();
		builder.Property(e => e.LastUpdatedAt).IsRequired();
		builder.Property(e => e.IsEnabled).IsRequired();
	}
}