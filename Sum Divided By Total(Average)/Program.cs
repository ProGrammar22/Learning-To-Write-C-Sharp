using System;

class Test
{
    static void Main(string[] args)
    {
        decimal b, c, d;
        string a;

        c = 0;
        d = 0;

        do
        {
            Console.Write("Input = ");

            a = Console.ReadLine();

            b = Convert.ToDecimal(a);

            if (b == -1) break;
            {
                c = c + b;
                d++;
            }
        }
        while (b != -1);

        b = c / d;

        Console.Write("Ans = " + b);
    }
}