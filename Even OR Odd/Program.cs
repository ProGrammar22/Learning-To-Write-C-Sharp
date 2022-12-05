using System;
class Test
{
    static void Main(string[] args)
    {
        Console.Write("Input Number: ");

        string b = Console.ReadLine();

        int a = Convert.ToInt32(b);

        if (a % 2 == 0)

            Console.Write("Input = Even");

        else

            Console.Write("Input = Odd");
    }
}