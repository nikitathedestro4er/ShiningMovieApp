using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.ObjectPool;
using RabbitMQ.Client;
using Services.Abstractions;

namespace Shining.Services.EmailService
{
    public static class RabbitMQServiceCollectionExtensions
    {
        public static IServiceCollection AddRabbitMQ(this IServiceCollection services, IConfiguration configuration)
        {
            var config = configuration.GetSection("rabbit");
            
            services.Configure<RabbitMQOptions>(config);

            services.AddSingleton<ObjectPoolProvider, DefaultObjectPoolProvider>();

            services.AddSingleton<IPooledObjectPolicy<IModel>, RabbitMQModelPooledObjectPolicy>();

            services.AddSingleton<IRabbitMQService, RabbitMQService>();

            return services;
        }
    }
}