# Corso protocolli di comunicazione IoT

# Scenario aziendale: Only Cars rappresenta un'azienda all'avanguardia nel settore del noleggio auto, distinguendosi per l'uso di tecnologie innovative e sistemi interconnessi. Questo le permette di offrire un servizio personalizzato e efficiente, con una gestione ottimizzata del parco auto e una comunicazione immediata con i clienti. Only Cars si posiziona così come leader nel mercato del noleggio auto, con un occhio sempre attento all'evoluzione tecnologica e alle esigenze dei consumatori moderni.

# Protocollo: COaP

# Descrizione del codice: CoAP (Constrained Application Protocol) è un protocollo di trasferimento web progettato per lavorare in ambienti limitati, con scarsa larghezza di banda ed energia, e dove è necessaria una comunicazione rapida e ininterrotta. Design del Sistema:
Sender (Macchina): La macchina che affitta l’azienda “Only Cars” agirà come il sender. Questa macchina raccoglierà i dati da vari sensori (ad esempio, velocità, posizione GPS, stato del motore) e li invierà al receiver.
Receiver: Il receiver rappresenta il sistema centrale dell’azienda che riceve i dati inviati dalla macchina.
Implementazione:
Identificazione delle Risorse: Ogni risorsa (ad esempio, velocità, posizione, stato del motore) sulla macchina avrà un Uniform Resource Identifier (URI) univoco. Questo consente al receiver di accedere alle risorse specifiche.
CoAP Message Format:
I dati verranno trasmessi in pacchetti di messaggi CoAP. Questi pacchetti includono informazioni come il tipo di messaggio (CON o NON), il codice di metodo (GET, POST, PUT, DELETE), l’URI della risorsa e il payload (dati effettivi).
I messaggi CON richiedono un acknowledgment dal receiver, mentre i messaggi NON non richiedono acknowledgment.
Metodi CoAP:
GET: Utilizzato per recuperare informazioni sulla risorsa identificata dall’URI di richiesta. Il server risponde con un codice di risposta (ad esempio, 200 OK) e la rappresentazione della risorsa.
POST: Crea una nuova risorsa subordinata sotto l’URI genitore richiesto dal client. Il server risponde con un codice di risposta (ad esempio, 201 Created) o un codice di errore (ad esempio, 4xx).
DELETE: Elimina la risorsa identificata dall’URI richiesto. Il server risponde con un codice di risposta (ad esempio, 200 OK) se l’operazione ha successo.
PUT: Aggiorna o crea la risorsa identificata dall’URI di richiesta con il corpo del messaggio incluso.
In particolare potremmo sfruttare le funzionalità CON e RST. CON per limitare il traffico dati e RST per creare un sistema di allarmistica.

