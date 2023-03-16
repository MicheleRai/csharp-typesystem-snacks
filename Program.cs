snack1();
//snack2();

void snack1()
{
    int num1 = Convert.ToInt32(Console.ReadLine());
    int num2 = Convert.ToInt32(Console.ReadLine());

    int sum = num1 - num2;

    if (num1 == num2)
    {
        Console.WriteLine("Numbers are equal");
    }
    else
    {
        Console.WriteLine(sum);
    }
}

void snack2()
{
    string str1 = Console.ReadLine() ?? "";
    string str2 = Console.ReadLine() ?? "";

    if (str1.Length > str2.Length)
    {
        Console.WriteLine(str1);
        Console.WriteLine(str2);
    }
    else
    {
        Console.WriteLine(str2);
        Console.WriteLine(str1);
    }
}
