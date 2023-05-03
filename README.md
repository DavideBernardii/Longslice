# Longslice

## Obiettivo codice
Data una stringa formata solo da cifre, calcolare il prodotto più grande per una sua sottostringa contigua di cifre di lunghezza N.
## Preview del codice
<img  height="500" src="https://user-images.githubusercontent.com/127590023/235290145-fb8cf836-a2b9-4737-abed-f1795e1999f8.png"/>

## Breve descrizione del codice

Questo codice definisce una classe statica chiamata "LargestSeriesProduct" che ha un metodo statico chiamato "GetLargestProduct". 

"GetLargestProduct" accetta due parametri: una stringa "digits" e un intero "span". Questo metodo calcola il prodotto più grande di una serie di cifre successive di lunghezza "span" all'interno della stringa "digits".

Se la lunghezza della stringa "digits" è inferiore alla lunghezza "span", viene generata un'eccezione "ArgumentException".

Il metodo utilizza un ciclo for per scorrere attraverso la stringa "digits" e un altro ciclo for per calcolare il prodotto di ogni serie di cifre di lunghezza "span" all'interno della stringa. Viene quindi conservato il prodotto più grande calcolato e restituito come risultato una volta terminato il ciclo for.

Quindi il codice sopra descritto fornisce una soluzione per calcolare il prodotto più grande di una serie di cifre continue di una lunghezza specificata all'interno di una stringa.
