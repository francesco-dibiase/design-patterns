# DESIGN PATTERNS - .NET IMPLEMENTATION

---

0. [**Struttura del progetto**](#struttura-del-progetto)
1. [**Pattern creazionali**](#1-pattern-creazionali)

   * [Abstract factory](#abstract-factory)
   * [Builder](#builder)
   * [Factory method](#factory-method)
   * [Prototype](#prototype)
   * [Singleton](#singleton)
2. [**Pattern strutturali**](#2-pattern-strutturali)

   * [Adapter](#adapter)
   * [Bridge](#bridge)
   * [Composite](#composite)
   * [Decorator](#decorator)
   * [Facade](#facade)
   * [Proxy](#proxy)
3. [**Pattern Comportamentali**](#3-pattern-comportamentali)

   * [Chain of responsibility](#chain-of-responsibility)
   * [Command](#command)
   * [Interpreter](#interpreter)
   * [Iterator](#iterator)
   * [Mediator](#mediator)
   * [Memento](#memento)
   * [Observer](#observer)
   * [State](#state)

# INTRODUZIONE

---

Questo progetto è nato con il triplice intento di:

1. Avere sempre a disposizione un punto di riferimento, sia teorico che pratico, per lo studio e la comprensione dei Design Patterns (o “schemi architetturali”).

2. Implementare personalmente ciascun pattern, osservandone nel tempo l’evoluzione sia in base alla mia crescita come sviluppatore, sia ai cambiamenti del paradigma di programmazione.

3. Divertirmi e imparare, **”because coding is fun”**. 👾

Le descrizioni dei pattern, tratte dal libro “Design Patterns — Elements of Reusable Object-Oriented Software”, sono state tradotte in italiano e adattate da me per questo progetto.
Il repository è pubblico, sotto licenza MIT, così che chiunque possa consultarlo, usarlo, commentarlo o criticarlo costruttivamente.
Spero che possa essere utile a qualcuno, o semplicemente offrire nuovi spunti di riflessione.

---

# STRUTTURA DEL PROGETTO

Il progetto consta di 3 cartelle principali, ognuna con il nome di una categoria di Design Pattern, ed una di varie utility di progetto. Di seguito una breve descrizione di tutte e tre.

---

# 1. Pattern Creazionali

> L'obiettivo dei pattern creazionali è astrarre l'operazione di istanziamento di un oggetto, rendendo indipendente il sistema dal modo in cui l'oggetto viene creato, composto e rappresentato. Viene usato il principio dell'ereditarietà per variare la quantità e la tipologia di oggetti istanziabili, e si delega la creazione di questi ultimi a un altro oggetto.

## Abstract factory

Fornisce un’interfaccia (a runtime) per la creazione di oggetti tra loro correlati o dipendenti da un contesto comune, senza specificare la loro classe concreta.

## Builder

Fornisce un'astrazione per la costruzione complessa di oggetti, separando la sua rappresentazione dal compito dell'istanziamento, affinché si possano creare rappresentazioni differenti di oggetti.

## Factory method

Fornisce un'astrazione per la creazione di un oggetto, delegando alle sottoclassi la decisione su quale classe concreta istanziare.

## Prototype

Specifica il tipo di oggetto da creare, usando un'istanza prototipica, e creando nuovi oggetti copiando il prototipo. Le istanze successive condividono attributi e proprietà.

## Singleton

Permette e assicura che una classe abbia una ed una sola istanza, oltre a garantire un accesso globale ad essa.

---

# 2. Pattern Strutturali

> I pattern strutturali sono responsabili di come classi e oggetti vengono composti per formare strutture più grandi e complesse. Particolarmente utili per far sì che classi indipendenti, da diverse librerie, lavorino insieme.
> La flessibilità aggiunta nell'usare questi tipi di pattern sta nella possibilità di cambiare la composizione di una struttura a runtime.

## Adapter

Converte l’interfaccia di una classe in un’altra interfaccia che il client si aspetta, permettendo così la collaborazione tra classi che altrimenti non potrebbero.

## Bridge

Disaccoppia l’astrazione dall’implementazione, così che possano variare indipendentemente.

## Composite

Compone oggetti in una struttura ad albero per rappresentare una gerarchia uno a molti, in modo che il client possa trattare sia singoli oggetti che composizioni di oggetti uniformemente.

## Decorator

Aggiunge dinamicamente nuove responsabilità a un oggetto, fornendo un’alternativa all’ereditarietà, più flessibile e dinamica, per estendere funzionalità.

## Facade

Fornisce un’interfaccia per interagire con un sottosistema di altre interfacce, rendendo il sottosistema più semplice da utilizzare.

## Proxy

Fornisce un surrogato (o un "segnaposto") che funge da tramite per l’accesso a un oggetto.

---

# 3. Pattern Comportamentali

> I pattern comportamentali sono responsabili dell’implementazione di algoritmi e dell’assegnazione di responsabilità tra oggetti. Questi pattern caratterizzano un flusso di controllo complesso, difficile da seguire durante il runtime. Spostano l’attenzione dal flusso di controllo, per permetterti di concentrarti solo sul modo in cui gli oggetti sono interconnessi.

## Chain Of Responsibility

Permette di passare una richiesta lungo una catena di oggetti fino a che uno di essi la gestisce, evitando di accoppiare in modo rigido mittente e destinatario.

## Command (Action, Transaction)

Incapsula una richiesta in un oggetto, permettendoti di parametrizzare il client con diverse richieste, code o richieste di log, consentendo inoltre di gestire anche operazioni annullabili o ripetibili.

## Interpreter

Dato un linguaggio, si definisce una rappresentazione per la sua grammatica insieme a un interprete che usa tale rappresentazione per interpretare le frasi del linguaggio.

## Iterator

Fornisce accesso agli elementi di un oggetto aggregato sequenzialmente, senza esporre la sua rappresentazione sottostante.

## Mediator

Fornisce un oggetto che incapsula le modalità di interazione tra un insieme di oggetti, promuovendo un legame tra essi non vincolante, evitando riferimenti espliciti reciproci.

## Memento

Cattura ed esternalizza lo stato interno di un oggetto, ma senza violare il principio di incapsulamento, così che l’oggetto possa ripristinare il suo stato precedentemente salvato.

## Observer

Stabilisce una relazione uno a molti tra oggetti, così che quando un oggetto cambia stato, tutti gli altri oggetti vengano notificati di tale cambiamento e reagiscano di conseguenza.

## State

Permette a un oggetto di modificare il suo comportamento quando il suo stato interno cambia, così da far sembrare che l’oggetto abbia cambiato classe.
