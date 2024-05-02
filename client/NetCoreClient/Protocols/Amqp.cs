using System;
using System.Text;
using RabbitMQ.Client;

namespace NetCoreClient.Protocols
{
    internal class Amqp : IProtocolInterface
    {
        private const string EXCHANGE_NAME = "iot2024/";
        private IModel channel;
        private string endpoint;

        public Amqp(string endpoint)
        {
            this.endpoint = endpoint;

            Connect();
        }

        private void Connect()
        {
            var factory = new ConnectionFactory() { HostName = this.endpoint, Port = 5672 };
            var connection = factory.CreateConnection();
            channel = connection.CreateModel();

            channel.ExchangeDeclare(exchange: EXCHANGE_NAME, type: ExchangeType.Topic);
        }

        public void Send(string data, string sensor)
        {
            var message = Encoding.UTF8.GetBytes(data);
            var routingKey = EXCHANGE_NAME + sensor + "Top";

            channel.BasicPublish(exchange: EXCHANGE_NAME, routingKey: routingKey, basicProperties: null, body: message);
        }
    }
}
