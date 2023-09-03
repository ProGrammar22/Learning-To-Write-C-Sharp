using System;

class Test
{
    static void Main(string[] args)
    {
        Console.Write("Input = ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input = ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        int lcm = LCM(firstNumber, secondNumber);

        Console.WriteLine("LCM = " + lcm);
    }

    static int LCM(int a, int b)
    {
        return a * b / GCD(a, b);
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}