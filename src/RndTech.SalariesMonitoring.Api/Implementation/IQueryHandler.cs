namespace RndTech.SalariesMonitoring.Api.Implementation;

public interface IQueryHandler<in TQuery, TResult>
{
	ValueTask<TResult> Handle(TQuery query, CancellationToken ct);
}