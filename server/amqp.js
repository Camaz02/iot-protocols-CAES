const amqp = require('amqplib');
const sqlite3 = require('sqlite3').verbose();

// Apriamo il database
let db = new sqlite3.Database('SensorsData.db', (err) => {
  if (err) {
    console.error(err.message);
  }
  console.log('Connesso al database.');
});

amqp.connect('amqp://localhost', function(error0, connection) {
  if (error0) {
    throw error0;
  }
  connection.createChannel(function(error1, channel) {
    if (error1) {
      throw error1;
    }
    let queue = 'iot2024/speedTop';

    channel.assertQueue(queue, {
      durable: false
    });

    console.log(" [*] In attesa di messaggi in %s.", queue);

    channel.consume(queue, function(msg) {
      console.log(" [x] Ricevuto %s", msg.content.toString());

      // Inseriamo i dati
      db.run(`INSERT INTO DataSensors (Speed) VALUES(?)`, [msg.content.toString()] , function(err) {
        if (err) {
          return console.log(err.message);
        }
        console.log(`Una riga è stata inserita con rowid ${this.lastID}`);
      });

    }, {
      noAck: true
    });
  });
});

// Chiudiamo la connessione al database
// db.close((err) => {
//   if (err) {
//     console.error(err.message);
//   }
//   console.log('Chiusura della connessione al database.');
// });