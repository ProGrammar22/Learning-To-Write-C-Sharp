using System;

class Test
{
    static void Main(string[] args)
    {
        Console.Write("Input = ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine("Output = " + i);
        }
    }
}