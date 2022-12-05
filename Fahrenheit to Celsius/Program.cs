using System;

class Test
{
    static void Main(string[] args)
    {
        double c;

        Console.Write("Input = ");

        string f = Console.ReadLine();

        c = Convert.ToDouble(f);

        c = (c - 32) * 0.5556;

        Console.WriteLine(c + " °C");
    }
}