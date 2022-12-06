using System;

class Test
{
    static void Main(string[] args)
    {
        int result = 0;

        Console.Write("First Input = ");

        string a = Console.ReadLine();
        int b = Convert.ToInt32(a);

        Console.Write("Second Input = ");

        a = Console.ReadLine();
        int c = Convert.ToInt32(a);

        Print(b, c, ref result);

        Console.WriteLine("Answer = " + result);
    }
    static void Print(int b, int c, ref int result)
    {
        result = b * c;
    }
}