using System;

class Test
{
    static void Main(string[] args)
    {
        decimal sum = 0;

        int count = 0;

        while (true)
        {
            Console.Write("Input = ");
            decimal input = Convert.ToDecimal(Console.ReadLine());

            if (input == -1)
            {
                break;
            }
            sum += input;
            count++;
        }
        decimal average = sum / count;

        Console.Write("Ans = " + average);
    }
}