using System;

class Test
{
    static void Main(string[] args)
    {
        Console.Write("Input = ");
        double celsius = (Convert.ToDouble(Console.ReadLine()) - 32) * 5 / 9;

        Console.WriteLine(celsius + " °C");
    }
}