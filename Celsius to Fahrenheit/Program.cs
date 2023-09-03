using System;

class Test
{
    static void Main(string[] args)
    {
        Console.Write("Input = ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        fahrenheit = (fahrenheit * 1.8) + 32;

        Console.WriteLine(fahrenheit + " °F");
    }
}