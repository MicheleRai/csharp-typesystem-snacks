//snack1();
//snack2();
//snack3();
//snack4();
//snack5();
using System;

snack6();



void snack1()
{
    Console.WriteLine("Confronta due numeri e trovane il maggiore");

    Console.WriteLine("Inserisci il primo numero");
    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Inserisci il secondo numero");
    int num2 = Convert.ToInt32(Console.ReadLine());


    if (num1 == num2)
    {     
        Console.WriteLine("I numeri sono equivalenti");
    }
    else if (num1 > num2)
    {

        Console.WriteLine("Il maggiore è:");

        Console.WriteLine(num1);
    }
    else
    {

        Console.WriteLine("Il maggiore è:");

        Console.WriteLine(num2);
    }
}

void snack2()
{
    Console.WriteLine("Confronta due numeri e trovane il maggiore");

    Console.WriteLine("Inserisci la prima parola");

    string str1 = Console.ReadLine() ?? "";

    Console.WriteLine("Inserisci la seconda parola");

    string str2 = Console.ReadLine() ?? "";

    Console.WriteLine("Le due parole che hai inserito sono:");

    if (str1.Length > str2.Length)
    {
        Console.WriteLine(str2);
        Console.WriteLine(str1);
    }
    else
    {
        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
}

void snack3()
{
    Console.WriteLine("Calcola la somma di 10 numeri");


    var ints = new int[10];

    for (int i = 0; i < 10; i++)
    {

        Console.WriteLine("Inserisci un numero");
        ints[i] = Convert.ToInt32(Console.ReadLine());

    }

    Console.WriteLine("la somma dei tuoi 10 numeri è:");
    int sum = ints.Sum();
    Console.WriteLine(sum);

}

void snack4()
{
    int[] ints = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int sum = ints.Sum();
    int media = sum / ints.Length;

    Console.WriteLine("la somma di un array che va da 2 a 10 è:");

    Console.WriteLine(sum);

    Console.WriteLine("La media di un array che va da 2 a 10 è:");

    Console.WriteLine(media);

}
void snack5()
{
    Console.WriteLine("Inserisci un numero");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num % 2 == 0)
    {
        Console.WriteLine("Il numero inserito è pari");
        Console.WriteLine(num);
    }
    else
    {
        Console.WriteLine("Il numero da te inserito non è pari quindi il numero pari piu vicino a quello inserito è:");
        Console.WriteLine(num+1);

    }

}

void snack6()

{
    Console.WriteLine("Controlla se sei invitato alla festa");

    string[] invitati = { "marco", "giovanni", "edoardo", "piero", "michele", "giacomo", "andrea" };

    Console.WriteLine("Inserisci il tuo nome");

    string nome = Console.ReadLine() ?? "";

    if (invitati.Contains(nome.ToLower()))
    {
        Console.WriteLine("Prego puoi entrare e benvenuto alla festa!");
    }
    else
    {
        Console.WriteLine("Purtroppo non sei invitato, mi spiace");

    }

}
