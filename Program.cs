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




Console.WriteLine();
Console.WriteLine("esercizio n2 snack 1");
Console.WriteLine();
Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
Console.WriteLine();
//Istruzioni condizionali
//Snack1.L’utente inserisce due numeri in successione.
//Il software stampa il maggiore.
string mag1;
string mag2;

Console.WriteLine("inserisci 2 numeri e ti dirò quale dei 2 è il maggiore.  ");
mag1 = Console.ReadLine();
mag2 = Console.ReadLine();

if (Convert.ToInt32(mag1) > Convert.ToInt32(mag2))
{
    Console.WriteLine("il primo numero che hai inserito è il più grande");
}
if (Convert.ToInt32(mag1) < Convert.ToInt32(mag2))
{
    Console.WriteLine("il secondo numero che hai inserito è il più grande");
}
else
{
    Console.WriteLine("non vale non èra scritto di pensare anche a situazoioni diverse, stai barndo");
}

Console.WriteLine();
Console.WriteLine("snack 2");
Console.WriteLine();
Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
Console.WriteLine();
//Snack2.L’utente inserisce due parole in successione.
//Il software stampa prima la parola più corta, poi la parola più lunga.
string par1;
string par2;

Console.WriteLine("inserisci 2 parole e ti dirònquale è la più lunga.");
par1 = Console.ReadLine();
par2 = Console.ReadLine();

if (par1.Length > par2.Length)
{
    Console.WriteLine(par1 + " è la parola più lunga");
}
if (par1.Length < par2.Length)
{
    Console.WriteLine(par2 + " è la parola più lunga");
}
else
{
    Console.WriteLine("hanno la stessa lunghezza");
}


Console.WriteLine();
Console.WriteLine("snack 3");
Console.WriteLine();
Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
Console.WriteLine();
//Ciclo for
//Snack3.Il software deve chiedere per 10 volte all’utente di inserire un numero.
//Il programma stampa la somma di tutti i numeri inseriti.

int[] numeri = new int[10];
Console.WriteLine("scrivi 10 numeri");
int somma = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("scrivi il numero " + (i + 1));
    numeri[i] = Convert.ToInt32(Console.ReadLine());
    somma = somma + numeri[i];
}

Console.WriteLine(" la somma dei tuoi numeri è " + somma + "vuoi rivedere i tuoi numeri? si o no?");

string vista = Console.ReadLine();

if (vista == "si")
{
    for (int i = 0; i < numeri.Length; i++)
    {
        Console.WriteLine("questo è il " + (i + 1) + "° numero " + numeri[i]);
    }
}


Console.WriteLine();
Console.WriteLine("esercizio n4");
Console.WriteLine();
Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
Console.WriteLine();
//Snack4.Calcola la somma e la media dei numeri da 2 a 10.
//Operatore modulo

int[] numMed = new int[8];
int som = 0;

for (int i = 2; i <= 10; i++)
{
    som = som + i;
}

int med = som / 8;

Console.WriteLine(" la somma dei numeri da 2 a 8 è " + som + " mentre la media è " + med);



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

if (Convert.ToInt32(utNum) % 2 == 0)
{
    Console.WriteLine("è pari quindi eccoti il tuo numero " + utNum);
}
else
{
    Console.WriteLine("è dispari non mi piace quindi ora è " + (Convert.ToInt32(utNum) + 1));
}


Console.WriteLine();
Console.WriteLine("esercizio n6");
Console.WriteLine();
Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
Console.WriteLine();

//Snack6.In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
//Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla
//festa.

string[] name = { "anthony", "Gianluca", "Giuseppe", "Paolo" };

Console.WriteLine("devo vedere se sei tra gli invitati dimmi il tuo nome");

string utName = Console.ReadLine();

bool passed = false;

for (int i = 0; i < name.Length; i++)
{
    if (name[i] == utName)
    {
        Console.WriteLine("ben arrivato " + utName + " ti stavamo aspettando");
        passed = true;
    }
}

if (passed == false)
{
    Console.WriteLine("mi spiace non sei tra i partecipanti vuoi guardare la lista ? si o no?");
    string list = Console.ReadLine();

    if (list == "si")
    {
        for (int i = 0; i < name.Length; i++)
        {
            Console.WriteLine(name[i]);
        }
    }
}

Console.WriteLine();
Console.WriteLine("esercizio n7");
Console.WriteLine();
Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
Console.WriteLine();

//Snack7.Crea un array vuoto.
//Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo
//nell’array.

int[] loveDis = new int[6];
Console.WriteLine("dammi " + 6 + " numeri");
for (int i = 0; i < loveDis.Length; i++)
{

    Console.WriteLine("ancora " + (6 - i));

    int nn = Convert.ToInt32(Console.ReadLine());

    if (nn % 2 == 1)
    {
        loveDis[i] = nn;
    }
}

Console.WriteLine(" questi sono i tuoi numeri, non sono stati salvati i numeri con valore pari");
for (int i = 0; i < loveDis.Length; i++)
{
    if (loveDis[i] != 0)
    {
        Console.WriteLine(loveDis[i]);
    }
}


Console.WriteLine();
Console.WriteLine("esercizio n8");
Console.WriteLine();
Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
Console.WriteLine();

//Snack8.Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in
//posizione dispari.

int[] myNumber = { 10, 33, 51, 90, 7, 4, 7, 3, 4, 8, 1, 2, 3, 4, 6 };
int somDis = 0;

for (int i = 0; i < myNumber.Length; i++)
{
    if (i % 2 == 1)
    {
        somDis = somDis + myNumber[i];
    }
}

Console.WriteLine("la somma dei numeri inseriti nel array in posizioni dispari è " + somDis);



Console.WriteLine();
Console.WriteLine("esercizio n9");
Console.WriteLine();
Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
Console.WriteLine();

//Snack9.Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
//Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la
//somma degli elementi è minore di 50.
//Random

int[] sn9 = new int[51];
int somSn9 = 0;

Console.WriteLine("inserisci numeri finche non arrivi ad una somma adeguata");
for (int i = 0; somSn9 < 50; i++)
{
    Console.WriteLine("inserisci");
    int pp = Convert.ToInt32(Console.ReadLine());
    if (pp != 0)
    {
        sn9[i] = pp;
        somSn9 = somSn9 + pp;
    }
}

Console.WriteLine("hai superato la cifra richiesta e questi sono i tuoi numeri");

for (int i = 0; i < sn9.Length; i++)
{
    if (sn9[i] != 0)
    {
        Console.WriteLine(sn9[i]);
    }
}

Console.WriteLine();
Console.WriteLine("esercizio n10");
Console.WriteLine();
Console.WriteLine("-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.");
Console.WriteLine();

//Snack10.Fai inserire un numero, che chiameremo N, all’utente.
//Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
//Ogni volta che ne crei uno, stampalo a schermo.

Console.WriteLine("quanti druppi da 10 numeri random vuoi ?");

int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int[] arrP = new int[10];

    for (int inde = 0; inde < 10; inde++)
    {
        var rand = new Random();

        arrP[inde] = rand.Next(1,100);
    }

    for (int stamp = 0; stamp < arrP.Length; stamp++)
    {
        Console.WriteLine(arrP[stamp]);
    }

    Console.WriteLine("questa era la " + (i+1) + "° seguenza" );
}