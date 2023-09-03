using System;

class Test
{
    static void Main(string[] args)
    {
        int[] arr = { 4, 5 };

        Console.WriteLine("Array = " + arr[0] + "," + arr[1]);

        Change(arr);

        Console.WriteLine("Array = " + arr[0] + "," + arr[1]);
    }

    static void Change(int[] arr)
    {
        Console.Write("Choices : 1, 2\n Input : ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice == 1 || choice == 2)
        {
            Console.Write("Change " + arr[choice - 1] + " to : ");
            int newValue = Convert.ToInt32(Console.ReadLine());

            arr[choice - 1] = newValue;
        }
        else
        {
            Console.Write("Wrong Input\n");
        }
    }
}