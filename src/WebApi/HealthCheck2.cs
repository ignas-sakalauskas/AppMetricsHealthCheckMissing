using App.Metrics.Health;
using System.Threading;
using System.Threading.Tasks;

namespace WebApi
{
    public class HealthCheck2 : HealthCheck
    {
        public HealthCheck2()
            : base("HealthCheckWebApi")
        {
        }

        protected override async ValueTask<HealthCheckResult> CheckAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return HealthCheckResult.Healthy();
        }
    }
}
