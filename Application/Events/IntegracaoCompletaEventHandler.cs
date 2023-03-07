using MediatR;
using SeeSharp.Messaging;

namespace SeeSharp.Application.Events;

public class IntegracaoCompletaEventHandler : INotificationHandler<IntegracaoCompleta>
{
    private readonly IRabbitMQMessageSender _rabbitMQMessageSender;

    public IntegracaoCompletaEventHandler(IRabbitMQMessageSender rabbitMQMessageSender)
    {
        this._rabbitMQMessageSender = rabbitMQMessageSender;
    }

    public Task Handle(IntegracaoCompleta notification, CancellationToken cancellationToken)
    {
        // TODO: Disparar um evento ao rabbitMQ informando que a integracao foi completa

        return Task.CompletedTask;
    }
}
