using System;

class Test
{
    static void Main(string[] args)
    {
        int b;

        do
        {
            Console.Write("Input = ");

            string a = Console.ReadLine();

            b = Convert.ToInt32(a);

            if (b % 2 == 0)

                Console.WriteLine("Input = Even");

            else

                Console.WriteLine("Input = Odd");
        }
        while (b != -1);
    }
}