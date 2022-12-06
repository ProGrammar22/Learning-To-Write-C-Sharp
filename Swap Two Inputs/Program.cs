using System;

class Test
{
    static void Main(string[] args)
    {
        int b, c, d;
        string a, e;

        Console.Write("First Input = ");

        a = Console.ReadLine();

        b = Convert.ToInt32(a);

        Console.Write("Second Input = ");

        e = Console.ReadLine();

        c = Convert.ToInt32(e);

        d = c;
        c = b;
        b = d;

        Console.WriteLine("Fisrst Input = " + b);
        Console.WriteLine("Second input = " + c);
    }
}