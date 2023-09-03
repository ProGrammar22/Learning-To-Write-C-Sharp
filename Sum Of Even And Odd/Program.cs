using System;

class Test
{
    static void Main(string[] args)
    {
        int sumEven = 0, sumOdd = 0;

        Console.Write("Input = ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                sumEven += i;
            }
            else
            {
                sumOdd += i;
            }
        }
        Console.WriteLine("Sum of Even = " + sumEven);
        Console.WriteLine("Sum of Odd = " + sumOdd);
    }
}