using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeShop.AzureQueueLibrary.MessageSerializer
{
    public interface IMessageSerializer
    {

        T Deserialize<T>(string message);
        string Serialize(object obj);

    }

}
