namespace RndTech.SalariesMonitoring.Database.Models;

public class SalaryMonitoringRequestVacancy
{
	public Guid Id { get; set; }
	public Guid RequestId { get; set; }
	public SalaryMonitoringRequest Request { get; set; }
	
	public string ExternalId { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public string AlternateUrl { get; set; }
	public double? SalaryFrom { get; set; }
	public double? SalaryTo { get; set; }
	public string? SalaryCurrency { get; set; }
	public bool? SalaryIsGross { get; set; }
	public string? ScheduleId { get; set; }
	public string? ScheduleName { get; set; }
	public string? ExperienceId { get; set; }
	public string? ExperienceName { get; set; }
	public string? EmploymentId { get; set; }
	public string? EmploymentName { get; set; }
	public string? CompanyId { get; set; }
	public string? CompanyName { get; set; }
}