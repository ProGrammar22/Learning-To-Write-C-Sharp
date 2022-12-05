using System;

class Test
{
    static void Main(string[] args)
    {
        int c, d, e;
        string a, b;

        Console.Write("Input First Number: ");

        a = Console.ReadLine();

        Console.Write("Input Second Number: ");

        b = Console.ReadLine();

        c = Convert.ToInt32(a);
        d = Convert.ToInt32(b);
        e = c + d;

        Console.WriteLine("Ans = " + e);
    }
}