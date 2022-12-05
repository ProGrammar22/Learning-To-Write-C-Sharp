using System;

class Test
{
    static void Main(string[] args)
    {
        int c, d, e, f;
        string a, b;

        d = 0;
        e = 0;

        Console.Write("Input = ");

        a = Console.ReadLine();

        c = Convert.ToInt32(a);

        Console.Write("Input = ");

        b = Console.ReadLine();

        f = Convert.ToInt32(b);

        if (c > f)

            d = c;

        else
        {
            d = f;
        }
        for (e = d; ; e += d)
        {
            if (e % c == 0 && e % f == 0)
            {
                Console.WriteLine("LCM = " + e); break;
            }
        }
    }
}