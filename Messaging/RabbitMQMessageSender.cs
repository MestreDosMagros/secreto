using RabbitMQ.Client;
using System.Text;

namespace SeeSharp.Messaging;

public class RabbitMQMessageSender : IRabbitMQMessageSender
{
    public void Send(string message)
    {
        var factory = new ConnectionFactory() { HostName = "localhost" };
        using (var connection = factory.CreateConnection())
        using (var channel = connection.CreateModel())
        {
            channel.ExchangeDeclare(exchange: "mensagens", type: ExchangeType.Fanout);

            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(exchange: "mensagens", routingKey: "", basicProperties: null, body: body);

            Console.WriteLine($"Enviada a mensagem: {message}");
        }
    }
}
