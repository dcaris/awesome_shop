using Microsoft.WindowsAzure.Storage.Queue;

namespace AwesomeShop.AzureQueueLibrary.QueueConnection
{
    public interface ICloudQueueClientFactory
    {
        CloudQueueClient GetClient();
    }

}
