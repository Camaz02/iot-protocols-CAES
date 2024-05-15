# Corso protocolli di comunicazione IoT

# Scenario aziendale: Only Cars rappresenta un'azienda all'avanguardia nel settore del noleggio auto, distinguendosi per l'uso di tecnologie innovative e sistemi interconnessi. Questo le permette di offrire un servizio personalizzato e efficiente, con una gestione ottimizzata del parco auto e una comunicazione immediata con i clienti. Only Cars si posiziona così come leader nel mercato del noleggio auto, con un occhio sempre attento all'evoluzione tecnologica e alle esigenze dei consumatori moderni.

# Protocollo: AMQP

# Status: Funzionante

# Descrizione del codice:
Il protocollo AMQP (Advanced Message Queuing Protocol) è uno standard aperto per il passaggio di messaggi tra applicazioni o organizzazioni con grande affidabilità e sicurezza. Nel contesto di OnlyCars, il sender, equipaggiato con sensori di velocità, posizione e livello carburante, funge da produttore di messaggi. Questi messaggi sono incapsulati secondo lo standard AMQP e inviati al reciver. Il reciver, l'applicativo di OnlyCars, agisce come consumatore dei messaggi.
Per garantire una comunicazione efficace, il sender deve stabilire una connessione con il broker AMQP, che gestisce i messaggi in transito. È fondamentale che la connessione sia criptata per proteggere la sensibilità dei dati trasmessi. Una volta che il sender pubblica un messaggio, questo viene messo in una coda nel broker. Il reciver, tramite un processo chiamato 'binding', si sottoscrive a questa coda per ricevere i messaggi pertinenti.
Gli accorgimenti tecnici includono la configurazione di scambi (exchanges) e code che definiscono le regole di routing dei messaggi, la gestione degli acknowledgment per assicurare che ogni messaggio sia ricevuto e processato correttamente, e il monitoraggio continuo della connessione per prevenire e gestire eventuali interruzioni. Inoltre, è essenziale implementare un sistema di logging per tracciare tutte le operazioni e facilitare il debugging in caso di errori. Infine, per assicurare la scalabilità e l'affidabilità del sistema, si dovrebbero adottare pratiche come il load balancing e il clustering del broker AMQP.
