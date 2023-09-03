using System;

class Test
{
    static void Main(string[] args)
    {
        Console.Write("Input Number: ");
        int convertedInput = Convert.ToInt32(Console.ReadLine());

        if (convertedInput % 2 == 0)
        {
            Console.Write("Input = Even");
        }
        else
        {
            Console.Write("Input = Odd");
        }
    }
}
