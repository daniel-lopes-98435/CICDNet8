/*
using OpenTelemetry;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

namespace ContactManagement.Api.Configurations
{
    public static class OpenTelemetryConfig
    {
        public static IServiceCollection AddOpenTelemetryConfig(this IServiceCollection services)
        {
            // Configuração do rastreamento distribuído e métricas
            services.AddOpenTelemetry()
                .WithTracing(tracingBuilder =>
                {
                    tracingBuilder
                        .SetResourceBuilder(ResourceBuilder.CreateDefault().AddService("ContactManagementApi"))
                        .AddAspNetCoreInstrumentation()
                        .AddHttpClientInstrumentation()
                        .AddSqlClientInstrumentation();
                })
                .WithMetrics(metricsBuilder =>
                {
                    metricsBuilder
                        .SetResourceBuilder(ResourceBuilder.CreateDefault().AddService("ContactManagementApi"))
                        .AddAspNetCoreInstrumentation()
                        .AddPrometheusExporter();
                });

            return services;
        }
    }
}
*/
