using Fabrikam.Entities;

namespace Fabrikam.Utilities
{
    public class QueueUtil
    {
        public const string QueueServerAddress = "localsost";
        public static string GetQueueName(QueueType qType)
        {
            switch (qType)
            {
                case QueueType.Booking:
                    return "Booking";
                case QueueType.Scheduling:
                    return "Scheduling";
                default:
                    return "default";
            }
        }        
    }
}
