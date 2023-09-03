using System;

class Test
{
    static void Main(string[] args)
    {
        int sum = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Input = ");
            string userInput = Console.ReadLine();

            int convertedInput = Convert.ToInt32(userInput);

            sum += convertedInput;
        }
        Console.WriteLine("Ans = " + sum);
    }
}
