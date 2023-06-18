using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RndTech.SalariesMonitoring.Database.Models;

namespace RndTech.SalariesMonitoring.Database.ModelConfiguration;

public class SalaryMonitoringRequestJobTitleEntityTypeConfiguration
	: IEntityTypeConfiguration<SalaryMonitoringRequestJobTitle>
{
	public void Configure(EntityTypeBuilder<SalaryMonitoringRequestJobTitle> builder)
	{
		builder.ToTable("salary_monitoring_request_job_title");
		builder.Property(x => x.Id).HasColumnName("id");
		builder.Property(x => x.Name).HasColumnName("name");
		builder.Property(x => x.RequestId).HasColumnName("request_id");
		
		builder.HasKey(e => e.Id);
		builder.Property(e => e.Name).IsRequired();

		builder
			.HasOne(e => e.Request)
			.WithMany(e => e.JobTitles)
			.HasForeignKey(e => e.RequestId);

	}
}