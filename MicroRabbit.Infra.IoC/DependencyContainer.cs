using System;
using Microsoft.Extensions.DependencyInjection;
using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.Bus;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IEventBus, RabbitMQBus>();

        }
    }
}
