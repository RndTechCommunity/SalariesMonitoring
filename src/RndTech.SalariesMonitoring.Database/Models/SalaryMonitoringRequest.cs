namespace RndTech.SalariesMonitoring.Database.Models;

public class SalaryMonitoringRequest
{
	public Guid Id { get; set; }
	public DateTimeOffset CreatedAt { get; set; }
	public DateTimeOffset LastUpdatedAt { get; set; }
	public bool IsEnabled { get; set; }
	
	public ICollection<SalaryMonitoringRequestJobTitle> JobTitles { get; set; }
	public ICollection<SalaryMonitoringRequestRegion> Regions { get; set; }
	public ICollection<SalaryMonitoringRequestVacancy> Vacancies { get; set; }
}