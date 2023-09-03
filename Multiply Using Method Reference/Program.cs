using System;

class Test
{
    static void Main(string[] args)
    {
        int result = 0;

        Console.Write("First Input = ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Second Input = ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Multiply(firstNumber, secondNumber, ref result);

        Console.WriteLine("Answer = " + result);
    }
    static void Multiply(int firstNumber, int secondNumber, ref int result)
    {
        result = firstNumber * secondNumber;
    }
}