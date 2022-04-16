using AwesomeShop.AzureQueueLibrary.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeShop.AzureQueueLibrary.Messages
{
    public class BaseQueueMessage
    {

        public string Route { get; set; }

        public BaseQueueMessage(string route)
        {
            this.Route = route;
        }

    }

    public class SendEmailCommand : BaseQueueMessage
    {

        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }

        public SendEmailCommand() 
            : base(RouteNames.EmailBox)
        {

        }
    }
}
