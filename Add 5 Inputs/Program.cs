using System;

class Test
{
    static void Main(string[] args)
    {
        int c, d, e;
        string a;

        d = 0;
        e = 0;

        do
        {
            Console.Write("Input = ");

            a = Console.ReadLine();

            c = Convert.ToInt32(a);
            d = d + c;
            e++;
        }
        while (e != 5);

        Console.WriteLine("Ans = " + d);
    }
}