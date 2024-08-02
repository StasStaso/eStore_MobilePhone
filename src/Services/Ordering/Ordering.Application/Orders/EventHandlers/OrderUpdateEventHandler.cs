﻿namespace Ordering.Application.Orders.EventHandlers;

public class OrderUpdateEventHandler(ILogger<OrderUpdateEventHandler> logger)
    : INotificationHandler<OrderUpdateEvent>
{
    public Task Handle(OrderUpdateEvent notification, CancellationToken cancellationToken)
    {
        logger.LogInformation("Domain Event handled: {DomainEvent}", notification.GetType().Name);
        throw new NotImplementedException();
    }
}
