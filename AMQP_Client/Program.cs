using System;
using System.Text;
using RabbitMQ.Client;

/*
ConnectionFactory: Viene creata un’istanza di ConnectionFactory per configurare la connessione al server RabbitMQ. Vengono specificati l’URI del server, il nome utente e la password.
Creazione della connessione: Viene creata una connessione utilizzando la ConnectionFactory.
Creazione del canale: Viene creato un canale per inviare messaggi.
Dichiarazione della coda: Viene dichiarata una coda su RabbitMQ con il nome “my_queue”.
Invio del messaggio: Viene inviato il messaggio “Hello, RabbitMQ!” alla coda specificata.
Stampa a console: Viene visualizzato un messaggio sulla console per confermare l’invio del messaggio.
 */

class Program
{
    static void Main()
    {
        // Configurazione della connessione a RabbitMQ
        var factory = new ConnectionFactory
        {
            Uri = new Uri("amqps://vsorjpaw:RhgswDXv1IM8XJtcwQz7nWlCa6pEppLQ@rat.rmq2.cloudamqp.com/vsorjpaw"), // Indirizzo del server RabbitMQ
            UserName = "vsorjpaw", // Nome utente
            Password = "RhgswDXv1IM8XJtcwQz7nWlCa6pEppLQ" // Password
        };

        // Creazione di una connessione
        using var connection = factory.CreateConnection();

        // Creazione di un canale per inviare messaggi
        using var channel = connection.CreateModel();

        // Dichiarazione della coda su RabbitMQ
        channel.QueueDeclare(queue: "OC/TrialQueue", durable: false, exclusive: false, autoDelete: false, arguments: null);

        // Messaggio da inviare
        var message = "Only Cars";
        var body = Encoding.UTF8.GetBytes(message);

        // Invio del messaggio alla coda specificata
        channel.BasicPublish(exchange: "", routingKey: "OC/TrialQueue", basicProperties: null, body: body);

        // Stampa a console per confermare l'invio del messaggio
        Console.WriteLine($"Messaggio inviato: {message}");
    }
}


