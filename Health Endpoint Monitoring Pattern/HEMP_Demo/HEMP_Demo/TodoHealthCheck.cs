using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HEMP_Demo
{
    public class TodoHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var healthy = true;
            if (healthy)
                return Task.FromResult(HealthCheckResult.Healthy());
            return Task.FromResult(HealthCheckResult.Unhealthy());
        }
    }
}
