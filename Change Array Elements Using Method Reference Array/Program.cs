using System;

class Test
{
    static void Main(string[] args)
    {
        int[] arr = { 4, 5 };

        Console.WriteLine("Array = " + arr[0] + "," + arr[1]);

        Change(ref arr);

        Console.WriteLine("Array = " + arr[0] + "," + arr[1]);
    }
    static void Change(ref int[] arr)
    {
        Console.Write("Choices : 1, 2\n Input : ");

        string a = Console.ReadLine();
        int b = Convert.ToInt32(a);

        if (b == 1)
        {
            Console.Write("Change " + arr[0] + " to : ");

            a = Console.ReadLine();
            b = Convert.ToInt32(a);

            arr[0] = b;
        }
        else if (b == 2)
        {
            Console.Write("Change " + arr[1] + " to : ");

            a = Console.ReadLine();
            b = Convert.ToInt32(a);
            arr[1] = b;
        }
        else
        {
            Console.Write("Wrong Input\n");
        }
    }
}