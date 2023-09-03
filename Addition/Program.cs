using System;

class Test
{
    static void Main(string[] args)
    {
        Console.Write("Input First Number: ");
        int firstConvertedInput = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input Second Number: ");
        int secondConvertedInput = Convert.ToInt32(Console.ReadLine());

        int sum = firstConvertedInput + secondConvertedInput;

        Console.WriteLine("Ans = " + sum);
    }
}