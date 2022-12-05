using System;

class Test
{
    static void Main(string[] args)
    {
        double f;

        Console.Write("Input = ");

        string c = Console.ReadLine();

        f = Convert.ToDouble(c);

        f = (f * 1.8) + 32;

        Console.WriteLine(f + " °F");
    }
}