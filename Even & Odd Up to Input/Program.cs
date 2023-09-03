using System;

class Test
{
    static void Main(string[] args)
    {
        Console.Write("Input = ");
        int convertedInput = Convert.ToInt32(Console.ReadLine());

        while (convertedInput != 0)
        {
            if (convertedInput % 2 == 0)
            {
                Console.WriteLine(convertedInput + " = Even");
            }
            else
            {
                Console.WriteLine(convertedInput + " = Odd");
            }
            convertedInput--;
        }
    }
}