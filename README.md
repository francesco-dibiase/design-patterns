# DESIGN PATTERNS - .NET IMPLEMENTATION

[IT - Introduzione](#it)

[EN - Introduction](#en)


<a source="it"></a>

## INTRODUZIONE
___
Questo progetto è stato creato col triplice intento di:
1) Avere sempre a portata di mano un progetto da cui attingere delle nozioni teoriche e pratiche, fondamentali di sviluppo, riguardo gli "Schemi/Prototipi Architetturali" (che da qui in poi chiamerò "Design Pattern").

2) Avere la possibilità di implementare i suddetti Design Patterns di mio pugno, e nel tempo osservarne i cambiamenti apportati sia dalla mia crescita personale, sia dal cambiamento del paradigma.

3) Divertirmi e imparare, “Because coding is fun 👾”.
---

Le descrizioni fornite per tutto il progetto, nella lingua inglese, sono tratte dal libro "Design Patterns - Elements of reusable object-oriented software", le quali ho provveduto a tradurre in italiano.

Il repository è pubblico, sotto licenza MIT affinché chiunque possa consultarlo, usarlo, aggiungere commenti e muovere critiche.
E spero inoltre che possa essere utile a qualcuno, o possa fornire diversi spunti di riflessione.
___
## STRUTTURA DEL PROGETTO
Il progetto consta di 3 cartelle principali, ognuna con il nome di una categoria di Design Pattern, ed una di varie utility di progetto. Di seguito una breve descrizione di tutte e tre:

---
### 1) Pattern Creazionali
      L'obiettivo dei pattern creazionali è astrarre l'operazione di istanziamento di un oggetto, rendendo indipendente il sistema dal modo in cui l'oggetto viene creato, comosto e rappresentato.

Viene usato il principio dell'ereditarietà per variare la quantità e la tipologia di oggetti istanziabili, e si delega la creazione di questi ultimi ad un altro oggetto.
___
### 2) Pattern Strutturali
      I pattern strutturali sono responsabili di come classi e oggetti vengono composti per formare strutture più grandi e complesse. Particolarmente utili per far si che classi indipendenti, da diverse librerie, lavorino insieme.
La flessibilità aggiunta nell'usare questi tipi di pattern sta nella possibilità di cambiare la composizione di una struttura a runtime.
___
### 3) Pattern Comportamentali
     I pattern comportamentali sono responsabili dell'implementazione di algoritmi, e dell'assegnazione di responsabilità tra oggetti.
Questi pattern caratterizzano un flusso di controllo complesso, difficile da seguire durante a runtime. Spostano la tua attenzione dal flusso di controllo, per permetterti di concentrarti solo sul modo in cui gli oggetti sono interconnessi.
