namespace Services.Abstractions
{
    public interface IRabbitMQService
    {
        void Publish<T>(T message, string exchangeName, string exchangeType, string routeKey) where T : class;
    }
}