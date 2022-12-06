using System;

class Test
{
    static void Main(string[] args)
    {
        int b, c;

        Console.Write("Input = ");

        string a = Console.ReadLine();

        b = Convert.ToInt32(a);
        c = 0;

        do
        {
            c = c + b;
            b = b - 1;
        }
        while (b > 0);

        Console.Write("Ans = " + c);
    }
}