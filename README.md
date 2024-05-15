# Corso protocolli di comunicazione IoT

# Scenario aziendale: 
Only Cars rappresenta un'azienda all'avanguardia nel settore del noleggio auto, distinguendosi per l'uso di tecnologie innovative e sistemi interconnessi. Questo le permette di offrire un servizio personalizzato e efficiente, con una gestione ottimizzata del parco auto e una comunicazione immediata con i clienti. Only Cars si posiziona così come leader nel mercato del noleggio auto, con un occhio sempre attento all'evoluzione tecnologica e alle esigenze dei consumatori moderni.

# Protocollo: MQTT

# Stato: Funzionante

# Descrizione del codice:
Utilizzando il protocollo MQTT due client si scambiano dati attraverso un topic comune. Un client funge da trasmettitore, inviando informazioni relative allo stato e alla posizione del veicolo, mentre l'altro client agisce come ricevitore, probabilmente elaborando i dati ricevuti per monitorare e gestire il veicolo all'interno della flotta di car sharing. I dati trasmessi sono gli stessi di quelli di HTTPS(velocità, posizione e livello carburante). Il topic è raggiungibile a 'iot2024/OC/Cars/[id]' per le singole macchine. I dati vengono inviati ad un database azure nel cloud. Abbiamo applicato le impostazioni QoS = 1; cleansession = false; User e password sono ablilitati. Queste impostazioni sono state scelte per la naura dello scambio dati, la macchina può avere segnale o meno (es. gallerie). Per questi motivi è utile sfriuttare keepalive. 
