namespace RndTech.SalariesMonitoring.Database.Models;

public class SalaryMonitoringRequestJobTitle
{
	public Guid Id { get; set; }
	public Guid RequestId { get; set; }
	public SalaryMonitoringRequest Request { get; set; }
	public string Name { get; set; }

}