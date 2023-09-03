using System;

class Test
{
    static void Main(string[] args)
    {
        Console.Write("First Input = ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Second Input = ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Swap(ref firstNumber, ref secondNumber);

        Console.WriteLine("First Input = " + firstNumber);
        Console.WriteLine("Second Input = " + secondNumber);
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}