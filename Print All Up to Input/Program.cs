using System;

class Test
{
    static void Main(string[] args)
    {
        int b, c;

        Console.Write("Input = ");

        string a = Console.ReadLine();

        b = Convert.ToInt32(a);
        c = 0;

        do
        {
            c++;
            Console.WriteLine("Output = " + c);
        }
        while (c != b);
    }
}