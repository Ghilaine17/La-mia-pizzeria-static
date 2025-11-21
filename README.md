## nome repo: la-mia-pizzeria-static

Dobbiamo realizzare un’applicazione web che ci aiuti a gestire la nostra pizzeria.

Abbiamo bisogno di creare la nostra prima pagina (index) dove mostriamo tutte le pizze che prepariamo.

Una pizza avrà le seguenti informazioni :
+ un nome
+ una descrizione
+ una foto (url)
+ un prezzo

Modifichiamo quindi la view Index.cshtml generata in automatico da .Net Core scrivendo l’html che serve a noi per mostrare l’elenco delle pizze (possiamo creare una tabella con bootstrap o una qualche grafica a nostro piacimento che mostri l’elenco delle pizze...proviamo un po’ di creatività se vogliamo!)

Piccolo suggerimento : ricordatevi di inserire il seguente codice all’inizio della vostra view
@ {
      Layout = null;
}

