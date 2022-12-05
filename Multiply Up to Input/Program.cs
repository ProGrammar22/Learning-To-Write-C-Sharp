using System;

class Test
{
    static void Main(string[] args)
    {
        int b, c;

        Console.Write("Input = ");

        string a = Console.ReadLine();

        b = Convert.ToInt32(a);
        c = 1;

        do
        {
            c = c * b;
            b--;
        }
        while (b > 1);

        Console.Write("Ans = " + c);
    }
}