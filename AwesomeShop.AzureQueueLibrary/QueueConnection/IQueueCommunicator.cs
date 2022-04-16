using AwesomeShop.AzureQueueLibrary.Messages;

namespace AwesomeShop.AzureQueueLibrary.QueueConnection
{
    public interface IQueueCommunicator
    {
        T Read<T>(string message);
        Task SendAsync<T>(T obj) where T : BaseQueueMessage;
    }
}
