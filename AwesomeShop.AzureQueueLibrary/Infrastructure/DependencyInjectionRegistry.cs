using AwesomeShop.AzureQueueLibrary.MessageSerializer;
using AwesomeShop.AzureQueueLibrary.QueueConnection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeShop.AzureQueueLibrary.Infrastructure
{
    public static class DependencyInjectionRegistry
    {


        public static IServiceCollection AddAzureQueueLibrary(this IServiceCollection service, string queueConnectionString)
        {
            service.AddSingleton(new QueueConfig(queueConnectionString));
            service.AddSingleton<ICloudQueueClientFactory, CloudQueueClientFactory>();
            service.AddSingleton<IMessageSerializer, JsonMessageSerializer>();
            service.AddTransient<IQueueCommunicator, QueueCommunicator>();
            return service;
        }

    }
}
