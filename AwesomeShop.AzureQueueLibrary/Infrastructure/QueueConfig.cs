using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeShop.AzureQueueLibrary.Infrastructure
{
    public class QueueConfig
    {

        #region Constructor
        
        public QueueConfig()
        {

        }

        public QueueConfig(string queueConnectionString)
        {
            QueueConnectionString = queueConnectionString;
        } 

        #endregion

        #region Properties

        public string QueueConnectionString { get; } 

        #endregion

    }
}
