namespace RndTech.SalariesMonitoring.Database.Models;

public class SalaryMonitoringRequestRegion
{
	public Guid Id { get; set; }
	public Guid RequestId { get; set; }
	public SalaryMonitoringRequest Request { get; set; }
	public string ExternalId { get; set; }
	public string Name { get; set; }

}