// See https://aka.ms/new-console-template for more information
using System;

//Ciao Ragazzi/e
//Esercizio di oggi sugli array:
//Nome repo: csharp - cibi - preferiti
//Create un progetto App Console csharp-cibi-preferiti con VS2022.

//1.
//Nel programma inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi).
//L’array deve essere già inizializzato nel programma, e i vostri cibi preferiti non vanno chiesti all’utente tramite input.
//Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:

//2.
//La lunghezza della classifica
//La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
//Il vostro cibo top (prima posizione della classifica)
//Il vostro cibo preferito ma non troppo (ultima posizione della classifica)


//Le modalità di consegna sono le solite: repo GitHub, commit e push

//3.
//BONUS Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana. Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.
//Buon lavoro.

//1#
string[] prefiteFood = { "lumache al sugo", "trippa al sugo ", "polmoni fritti", "polenta", "cozze", "totani alla piastra", "sushi", "pasta ai funghi porcini" };

Console.WriteLine( "la classifica è composta da " + prefiteFood.Length + "elementi");

//2
for (int i = 0; i < prefiteFood.Length; i++)
{
    int position = 1 + i;
    Console.WriteLine( "posizione " + position + " " + prefiteFood[i]);
}

//3
Console.WriteLine( "---------------------------------------------------" );
if (prefiteFood.Length % 2 == 1)
{
    int middle = prefiteFood.Length / 2;
    Console.WriteLine("il cibo di mezzo è " + prefiteFood[middle]);
}
else
{
    int middle1 = prefiteFood.Length / 2;
    int middle2 = middle1 + 1;

    Console.WriteLine("essendo una classifica con un numero di elementi pari, i due elementi di mezzo sono: 1 " + prefiteFood[middle1] + " e 2 " + prefiteFood[middle2]);
}

Console.WriteLine("--------------- se ho capito male la consegna sono un tonno gigante--------------");