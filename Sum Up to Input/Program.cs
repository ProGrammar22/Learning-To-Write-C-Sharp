using System;

class Test
{
    static void Main(string[] args)
    {
        Console.Write("Input = ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= number; i++)
        {
            sum += i;
        }
        Console.Write("Ans = " + sum);
    }
}