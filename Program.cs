//snack1();
//snack2();
//snack3();
//snack4();
//snack5();
//snack6();
//snack7();
//snack8();
//snack9();
snack10();





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
void snack7()
{
    var ints = new int[6];
    for (int i = 0; i < 6; i++)
    {

        Console.WriteLine("Inserisci un numero");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 != 0) ints[i] = num;

    }
    foreach (var item in ints)
    {
        Console.WriteLine(item.ToString());
    }

}

void snack8()
{
    var ints = new int[10];
    var somma = 0;

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Inserisci un numero");
        ints[i] = Convert.ToInt32(Console.ReadLine());

    }
    for (int i = 0;i < ints.Length; i++)
    {
        if ((i + 2) % 2 == 0)
        {
            somma += ints[i];
        }
    }
    Console.WriteLine("La somma dei numeri dispari inseriti da te è:");

    Console.WriteLine(somma);

}
void snack9()
{
    int[] ints = new int[50];
    var somma = 0;
    int i = 0;

    while (somma < 50)
    {
        Console.WriteLine("Inserisci un numero: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if ((somma + num) < 50)
        {
            ints[i] = num;
            i++;
            somma += num;

            Console.WriteLine("La somma attuale è:");

            Console.WriteLine(somma);

            Console.WriteLine("L'array creato è:");

            for (int j = 0; j < i; j++)
            {
                Console.WriteLine($"{ints[j]} ");
            }

        }
        else if ((somma + num) == 50)
        {
            Console.WriteLine("La somma dei numeri da te inseriti ha raggiunto 50");

            Console.WriteLine("L'array creato è:");

            for (int j = 0; j < i; j++)
            {
                Console.WriteLine($"{ints[j]} ");
            }
        }
        else
        {
            Console.WriteLine("la somma supererebbe 50 quindi per piacere inserire un altro numero");

            Console.WriteLine("La somma attuale è:");

            Console.WriteLine(somma);

            Console.WriteLine("L'array creato è:");

            for (int j = 0; j < i; j++)
            {
                Console.WriteLine($" {ints[j]} ");
            }


        }
    }

}

void snack10()
{
    int N = Convert.ToInt32(Console.ReadLine());
    var random = new Random();

    for (int i = 0; i < N; i++)
    {
        var ints = new int[10];

        for (int j = 0; j < 10; j++)
        {
            ints[j] = random.Next(1, 100);
        }

        foreach (var num in ints)
        {
            Console.Write($"{num}; ");
        }

        Console.WriteLine();
    }
}