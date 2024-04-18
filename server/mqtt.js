const mqtt = require('mqtt')
const client  = mqtt.connect('mqtt://test.mosquitto.org')

client.on('connect', function () {
    console.log("Connesso");
    client.subscribe('iot2024/speedTop');
})
//------------------
const sqlite3 = require('sqlite3').verbose();

// Apriamo il database
let db = new sqlite3.Database('SensorsData.db', (err) => {
  if (err) {
    console.error(err.message);
  }
  console.log('Connesso al database.');
});

client.on('message', function (topic, message) {
  console.log('TOPIC: ' + topic + "\nMESSAGE: " + message.toString());

  // Inseriamo i dati
  db.run(` INSERT INTO DataSensors (Speed) VALUES(?)`, [message.toString()] , function(err) {
    if (err) {
      return console.log(err.message);
    }
    console.log(` Una riga è stata inserita con rowid ${this.lastID}` );
  });

})


// Chiudiamo la connessione al database
// db.close((err) => {
//   if (err) {
//     console.error(err.message);
//   }
//   console.log('Chiusura della connessione al database.');
// });
