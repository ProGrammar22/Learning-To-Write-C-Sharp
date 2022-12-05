using System;

class Test
{
    static void Main(string[] args)
    {
        Console.Write("First Input : ");

        string a = Console.ReadLine();
        int b = Convert.ToInt32(a);

        Console.Write("Second Input : ");

        a = Console.ReadLine();
        int c = Convert.ToInt32(a);

        Console.Write("Answer = " + Print(b, c));
    }
    static int Print(int b, int c)
    {
        int i = b * c;

        return i;
    }
}
