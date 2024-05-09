using System;
using System.Text;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

/*
Creiamo una connessione al server RabbitMQ e dichiariamo una coda chiamata “my_queue”.
Impostiamo il prefetch count a 1 per ricevere un solo messaggio alla volta.
Creiamo un consumer che ascolta la coda e gestisce i messaggi ricevuti.
Quando viene ricevuto un messaggio, lo stampiamo a console e confermiamo la ricezione.
 */

class Program
{
    static void Main()
    {
        var factory = new ConnectionFactory
        {
            //HostName = "amqps://vsorjpaw:RhgswDXv1IM8XJtcwQz7nWlCa6pEppLQ@rat.rmq2.cloudamqp.com/vsorjpaw" // Indirizzo del server RabbitMQ
            Uri = new Uri("amqps://vsorjpaw:RhgswDXv1IM8XJtcwQz7nWlCa6pEppLQ@rat.rmq2.cloudamqp.com/vsorjpaw"), // Indirizzo del server RabbitMQ
            UserName = "vsorjpaw", // Nome utente
            Password = "RhgswDXv1IM8XJtcwQz7nWlCa6pEppLQ" // Password
        };

        using var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();

        // Dichiarazione della coda
        channel.QueueDeclare(queue: "OC/TrialQueue", durable: false, exclusive: false, autoDelete: false, arguments: null);

        // Imposta il numero massimo di messaggi da ricevere contemporaneamente (1 in questo caso)
        channel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);

        // Crea un consumer per ricevere i messaggi
        var consumer = new EventingBasicConsumer(channel);

        // Evento scatenato quando viene ricevuto un messaggio
        consumer.Received += (sender, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            Console.WriteLine($"Messaggio ricevuto: {message}");

            // Conferma la ricezione del messaggio
            channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
        };

        // Registra il consumer per ascoltare la coda specificata
        channel.BasicConsume(queue: "OC/TrialQueue", autoAck: false, consumer: consumer);

        Console.WriteLine("In attesa di messaggi. Premi CTRL+C per uscire.");
        Console.ReadLine();
    }
}
