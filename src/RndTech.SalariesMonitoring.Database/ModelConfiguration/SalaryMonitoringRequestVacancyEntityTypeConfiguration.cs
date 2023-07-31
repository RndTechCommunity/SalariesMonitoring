using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RndTech.SalariesMonitoring.Database.Models;

namespace RndTech.SalariesMonitoring.Database.ModelConfiguration;

public class SalaryMonitoringRequestVacancyEntityTypeConfiguration
	: IEntityTypeConfiguration<SalaryMonitoringRequestVacancy>
{
	public void Configure(EntityTypeBuilder<SalaryMonitoringRequestVacancy> builder)
	{
		builder.ToTable("salary_monitoring_request_vacancy");
		builder.Property(x => x.Id).HasColumnName("id");
		builder.Property(x => x.Name).HasColumnName("name");
		builder.Property(x => x.Description).HasColumnName("description");
		builder.Property(x => x.AlternateUrl).HasColumnName("alternate_url");
		builder.Property(x => x.ExternalId).HasColumnName("external_id");
		builder.Property(x => x.RequestId).HasColumnName("request_id");
		builder.Property(x => x.SalaryFrom).HasColumnName("salary_from");
		builder.Property(x => x.SalaryTo).HasColumnName("salary_to");
		builder.Property(x => x.SalaryCurrency).HasColumnName("salary_currency");
		builder.Property(x => x.ScheduleId).HasColumnName("schedule_id");
		builder.Property(x => x.ScheduleName).HasColumnName("schedule_name");
		builder.Property(x => x.ExperienceId).HasColumnName("experience_id");
		builder.Property(x => x.ExperienceName).HasColumnName("experience_name");
		builder.Property(x => x.EmploymentId).HasColumnName("employment_id");
		builder.Property(x => x.EmploymentName).HasColumnName("employment_name");
		builder.Property(x => x.CompanyId).HasColumnName("company_id");
		builder.Property(x => x.CompanyName).HasColumnName("company_name");
		
		builder.HasKey(e => e.Id);
		builder.Property(e => e.Name).IsRequired();
		builder.Property(e => e.Description).IsRequired();
		builder.Property(e => e.AlternateUrl).IsRequired();
		builder.Property(e => e.ExternalId).IsRequired();
		builder.Property(e => e.RequestId).IsRequired();

		builder
			.HasOne(e => e.Request)
			.WithMany(e => e.Vacancies)
			.HasForeignKey(e => e.RequestId);

	}
}