using AwesomeShop.AzureQueueLibrary.Infrastructure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

namespace AwesomeShop.AzureQueueLibrary.QueueConnection
{
    public class CloudQueueClientFactory : ICloudQueueClientFactory
    {
        private readonly QueueConfig _config;
        private CloudQueueClient _client;

        public CloudQueueClientFactory(QueueConfig config)
        {
            this._config = config;
        }

        public CloudQueueClient GetClient()
        {
            if(this._client != null)
            {
                return this._client;
            }

            var storageAccount = CloudStorageAccount.Parse(_config.QueueConnectionString);
            _client = storageAccount.CreateCloudQueueClient();
            return _client;
        }
    }

}
