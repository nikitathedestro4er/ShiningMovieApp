namespace AuthenticationApi.Services.EmailService
{
    public class RabbitMQOptions
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string HostName { get; set; }

        public int Port { get; set; }

        public string VHost { get; set; }
    }
}