namespace Ordering.Application.Orders.EventHandlers.Domain;

public class OrderUpdateEventHandler(ILogger<OrderUpdateEventHandler> logger)
    : INotificationHandler<OrderUpdateEvent>
{
    public Task Handle(OrderUpdateEvent notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("Domain Event handled: {DomainEvent}", notification.GetType().Name);
        return Task.CompletedTask;
    }
}
