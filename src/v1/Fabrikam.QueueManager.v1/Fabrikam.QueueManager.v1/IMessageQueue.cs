using Fabrikam.Entities.v1;

namespace Fabrikam.QueueManager.v1
{
    public interface IMessageQueue
    {
        bool PushMessage(string message, QueueType qType);
        string PullMessage(QueueType qType);
    }
}
