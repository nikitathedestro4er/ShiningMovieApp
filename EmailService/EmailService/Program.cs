using System;
using System.IO;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Net;
using System.Net.Mail;

namespace EmailService
{
    class Program
    {
        static void Main()
        {
            SendingService sendingService = new SendingService();
            
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            IConfiguration config = builder.Build();

            var options = config.GetSection("rabbit").Get<RabbitMQOptions>();
            
            
            var factory = new ConnectionFactory()
            {
                UserName = options.UserName,
                Password = options.Password,
                VirtualHost = options.VHost,
                HostName = options.HostName,
                Port = options.Port,
                
            };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: "demo.queue.durable.dotnetcore.test",
                                    durable: true,
                                    exclusive: false,
                                    autoDelete: false,
                                    arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body.ToArray();
                    var message = Encoding.UTF8.GetString(body);
                    var email = JsonSerializer.Deserialize<Email>(message);
                    Console.WriteLine($"UserName--{email.Destination}----Content--{email.Body}");
                    sendingService.Send(email);
                };

                channel.BasicConsume(queue: "demo.queue.durable.dotnetcore.test",
                                    autoAck: true,
                                    consumer: consumer);
                Console.ReadLine();
            }
            
            
            
        }    
    }
}