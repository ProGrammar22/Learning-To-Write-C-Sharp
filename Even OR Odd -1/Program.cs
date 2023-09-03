using System;

class Test
{
    static void Main(string[] args)
    {
        int convertedInput;
        do
        {
            Console.Write("Input = ");
            convertedInput = Convert.ToInt32(Console.ReadLine());

            if (convertedInput % 2 == 0)
            {
                Console.WriteLine("Input = Even");
            }
            else
            {
                Console.WriteLine("Input = Odd");
            }
        }
        while (convertedInput != -1);
    }
}