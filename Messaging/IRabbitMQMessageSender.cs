namespace SeeSharp.Messaging;

public interface IRabbitMQMessageSender
{
    void Send(string message);
}
