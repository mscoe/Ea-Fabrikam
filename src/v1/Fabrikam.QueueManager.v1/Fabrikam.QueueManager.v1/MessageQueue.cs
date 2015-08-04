
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Fabrikam.Utilities.v1;
using System;

namespace Fabrikam.QueueManager.v1
{
    public class MessageQueue : IMessageQueue
    {
        ConnectionFactory factory;
        IConnection connection;
        IModel channel;
        IBasicProperties properties;

        public MessageQueue()
        {
            factory = new ConnectionFactory() { HostName = "strServer" };
            connection = factory.CreateConnection();
            channel = connection.CreateModel();
            properties = channel.CreateBasicProperties();
            properties.SetPersistent(true);
        }

        public bool PushMessage(string message, QueueType qType)
        {
            string queueName = QueueUtil.GetQueueName(qType);
            channel.QueueDeclare(queueName, true, false, false, null);          
            channel.BasicPublish("", queueName, properties, StringConverter.GetMessageByte(message));
            return true;
        }

        public string PullMessage(QueueType qType)
        {
            string queueName = QueueUtil.GetQueueName(qType);
            channel.QueueDeclare(queueName, true, false, false, null);
            var consumer = new QueueingBasicConsumer(channel);
            channel.BasicConsume(queueName, false, consumer);

            BasicDeliverEventArgs ea;
            bool flag = consumer.Queue.Dequeue(200, out ea);
            if (flag)
            {
                var body = ea.Body;
                var message = StringConverter.GetMessage(body);
                channel.BasicAck(ea.DeliveryTag, false);
                return message;
            }
            else
                return string.Empty;
        }
    }
}
