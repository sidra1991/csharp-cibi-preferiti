﻿// See https://aka.ms/new-console-template for more information
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




//Console.WriteLine();
//Console.WriteLine("esercizio n2 snack 1");
//Console.WriteLine();
//Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
//Console.WriteLine();
//Istruzioni condizionali
//Snack1.L’utente inserisce due numeri in successione.
//Il software stampa il maggiore.
//string mag1;
//string mag2;

//Console.WriteLine("inserisci 2 numeri e ti dirò quale dei 2 è il maggiore.  ");
// mag1 = Console.ReadLine();
// mag2 = Console.ReadLine();

//if (Convert.ToInt32(mag1) > Convert.ToInt32(mag2))
//{
//    Console.WriteLine("il primo numero che hai inserito è il più grande");
//} if (Convert.ToInt32(mag1) < Convert.ToInt32(mag2))
//{
//    Console.WriteLine("il secondo numero che hai inserito è il più grande");
//} else
//{
//    Console.WriteLine("non vale non èra scritto di pensare anche a situazoioni diverse, stai barndo");
//}

//Console.WriteLine();
//Console.WriteLine("snack 2");
//Console.WriteLine();
//Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
//Console.WriteLine();
//Snack2.L’utente inserisce due parole in successione.
//Il software stampa prima la parola più corta, poi la parola più lunga.
//string par1;
//string par2;

//Console.WriteLine("inserisci 2 parole e ti dirònquale è la più lunga.");
//par1 = Console.ReadLine();
//par2 = Console.ReadLine();

//if (par1.Length > par2.Length)
//{
//    Console.WriteLine(par1 + " è la parola più lunga");
//}
//if (par1.Length <par2.Length)
//{
//    Console.WriteLine(par2 + " è la parola più lunga");
//}
//else
//{
//    Console.WriteLine("hanno la stessa lunghezza");
//}


//Console.WriteLine();
//Console.WriteLine("snack 3");
//Console.WriteLine();
//Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
//Console.WriteLine();
//Ciclo for
//Snack3.Il software deve chiedere per 10 volte all’utente di inserire un numero.
//Il programma stampa la somma di tutti i numeri inseriti.

//int[] numeri = new int[10];
//Console.WriteLine("scrivi 10 numeri");
//int somma = 0;
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("scrivi il numero " + (i+1));
//    numeri[i] = Convert.ToInt32(Console.ReadLine());
//    somma = somma+numeri[i];
//}

//Console.WriteLine(" la somma dei tuoi numeri è " + somma + "vuoi rivedere i tuoi numeri? si o no?" );

//string vista = Console.ReadLine();

//if (vista == "si")
//{
//    for (int i = 0; i < numeri.Length ; i++)
//    {
//        Console.WriteLine("questo è il " + (i + 1)  + "° numero " + numeri[i]);
//    }
//}


//Console.WriteLine();
//Console.WriteLine("esercizio n4");
//Console.WriteLine();
//Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
//Console.WriteLine();
//Snack4.Calcola la somma e la media dei numeri da 2 a 10.
//Operatore modulo

//int[] numMed = new int[8];
//int som = 0;

//for (int i = 2; i <= 10; i++)
//{
//    som = som + i;
//}

//int med = som / 8;

//Console.WriteLine(" la somma dei numeri da 2 a 8 è " + som + " mentre la media è " + med);



Console.WriteLine();
Console.WriteLine("esercizio n5");
Console.WriteLine();
Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
Console.WriteLine();

//Snack5.Il software chiede all’utente di inserire un numero. Se il numero inserito è pari,
//stampa il numero, se è dispari, stampa il numero successivo.
//Array

Console.WriteLine("inserisci un numero");
string utNum = Console.ReadLine();

if ( Convert.ToInt32(utNum) % 2 == 0)
{
    Console.WriteLine( "è pari quindi eccoti il tuo numero " + utNum);
} else
{
    Console.WriteLine( "è dispari non mi piace quindi ora è " + (Convert.ToInt32(utNum) + 1));
}


Console.WriteLine();
Console.WriteLine("esercizio n6");
Console.WriteLine();
Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
Console.WriteLine();

//Snack6.In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
//Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla
//festa.
//Snack7.Crea un array vuoto.
//Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo
//nell’array.
//Snack8.Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in
//posizione dispari.
//Ciclo while
//Snack9.Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
//Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la
//somma degli elementi è minore di 50.
//Random
//Snack10.Fai inserire un numero, che chiameremo N, all’utente.
//Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
//Ogni volta che ne crei uno, stampalo a schermo.