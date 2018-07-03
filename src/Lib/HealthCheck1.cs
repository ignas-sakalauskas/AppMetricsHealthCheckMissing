using App.Metrics.Health;
using System.Threading;
using System.Threading.Tasks;

namespace Lib
{
    public class HealthCheck1 : HealthCheck
    {
        public HealthCheck1()
            : base("HealthCheckLib")
        {
        }

        protected override async ValueTask<HealthCheckResult> CheckAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return HealthCheckResult.Healthy();
        }
    }
}
