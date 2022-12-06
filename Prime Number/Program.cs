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
            c++;

            if (b % c == 0)
            {
                Console.WriteLine(b + " is not a Primr Number"); break;
            }
        }
        while (c < b);
        {
            if (b % c != 0)
            {
                Console.WriteLine(b + " is a Primr Number");
            }
        }
    }
}