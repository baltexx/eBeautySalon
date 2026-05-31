var builder = Host.CreateApplicationBuilder(args);

// TODO: Add RabbitMQ AsyncEventingBasicConsumer, retry with exponential backoff,
// SMTP notification service and ILogger based error logging.

var host = builder.Build();
host.Run();
