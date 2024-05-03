# Corso protocolli di comunicazione IoT

# Scenario aziendale: Only Cars rappresenta un'azienda all'avanguardia nel settore del noleggio auto, distinguendosi per l'uso di tecnologie innovative e sistemi interconnessi. Questo le permette di offrire un servizio personalizzato e efficiente, con una gestione ottimizzata del parco auto e una comunicazione immediata con i clienti. Only Cars si posiziona così come leader nel mercato del noleggio auto, con un occhio sempre attento all'evoluzione tecnologica e alle esigenze dei consumatori moderni.

# Protocollo: HTTPS

# Stato: Funzionante

# Descrizione del codice:
Utilizzando il protocollo HTTPS, garantiamo che la comunicazione tra il client e il server sia sicura e criptata, proteggendo così i dati sensibili degli utenti. Il client, agendo come una simulazione di un'automobile connessa, può inviare informazioni vitali come la posizione, lo stato del veicolo, le richieste di prenotazione al server, livello carburante e velocità (implementati velocità, posizione e livello carburante). il server immagazzina i dati in un database nel infrastruttura cloud  Azure. La comunicazione avviene in pollig attualmente, ma sarebbe ideale inviare i dati in pacchetti ogni tot tempo in base allo stato del auto. Per assicurare la comunicazione tra i due devices che girano in due PC diversi, è stato utilizzato Ngrock. L'URL dove vengono ricevuti i dati è: 'Only Cars/cars/:id'.
