using System;

class Test
{
    static void Main(string[] args)
    {
        int b, c, d;

        c = 0;
        d = 0;

        Console.Write("Input = ");

        string a = Console.ReadLine();

        b = Convert.ToInt32(a);

        do
        {
            if (b % 2 == 0)
            {
                c = c + b;
            }
            else
            {
                d = d + b;
            }
            b--;
        }
        while (b > 0);

        Console.WriteLine("Sum of Even = " + c);

        Console.WriteLine("Sum of Odd = " + d);
    }
}