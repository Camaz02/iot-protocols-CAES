# Corso protocolli di comunicazione IoT

# Scenario aziendale: 
Only Cars rappresenta un'azienda all'avanguardia nel settore del noleggio auto, distinguendosi per l'uso di tecnologie innovative e sistemi interconnessi. Questo le permette di offrire un servizio personalizzato e efficiente, con una gestione ottimizzata del parco auto e una comunicazione immediata con i clienti. Only Cars si posiziona così come leader nel mercato del noleggio auto, con un occhio sempre attento all'evoluzione tecnologica e alle esigenze dei consumatori moderni.

# Protocollo: MQTT

# Stato: Funzionante

# Descrizione del codice:
Utilizzando il protocollo MQTT due client si scambiano dati attraverso un topic comune. Un client funge da trasmettitore, inviando informazioni relative allo stato e alla posizione del veicolo, mentre l'altro client agisce come ricevitore, probabilmente elaborando i dati ricevuti per monitorare e gestire il veicolo all'interno della flotta di car sharing. I dati trasmessi sono gli stessi di quelli di HTTPS. Il topic è raggiungibile a 'iot2024/OC/Cars/[id]'
Questo tipo di architettura non solo facilita la raccolta in tempo reale dei dati del veicolo, ma consente anche una comunicazione efficiente e scalabile, essenziale per un servizio di car sharing dinamico e reattivo alle esigenze degli utenti. 
