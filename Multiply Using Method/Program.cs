using System;

class Test
{
    static void Main(string[] args)
    {
        Console.Write("First Input : ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Second Input : ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Answer = " + Multiply(firstNumber, secondNumber));
    }
    static int Multiply(int a, int b)
    {
        return a * b;
    }
}
