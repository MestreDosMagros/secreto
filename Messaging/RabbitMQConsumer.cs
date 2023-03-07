using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace SeeSharp.Messaging;

public class RabbitMQConsumer : BackgroundService
{
    private readonly IConnection _connection;
    private readonly IModel _channel;

    public RabbitMQConsumer()
    {
        var factory = new ConnectionFactory() { HostName = "localhost" };
        _connection = factory.CreateConnection();
        _channel = _connection.CreateModel();
        _channel.ExchangeDeclare(exchange: "mensagens", type: ExchangeType.Fanout);
        _channel.QueueDeclare(queue: "mensagens", durable: false, exclusive: false, autoDelete: false, arguments: null);
        _channel.QueueBind(queue: "mensagens", exchange: "mensagens", routingKey: "");
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var consumer = new EventingBasicConsumer(_channel);
        consumer.Received += (model, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);

            _channel.BasicAck(ea.DeliveryTag, false);

            Console.WriteLine($"Recebida a mensagem: {message}");
        };

        _channel.BasicConsume(queue: "mensagens", autoAck: false, consumer: consumer);

        return Task.CompletedTask;
    }
}
