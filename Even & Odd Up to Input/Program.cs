using System;

class Test
{
    static void Main(string[] args)
    {
        int b;

        Console.Write("Input = ");

        string a = Console.ReadLine();

        b = Convert.ToInt32(a);

        do
        {
            if (b % 2 == 0)

                Console.WriteLine(b + " = Even");

            else

                Console.WriteLine(b + " = Odd");

            b = b - 1;
        }
        while (b != 0);
    }
}