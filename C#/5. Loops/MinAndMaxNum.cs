using System;

//Write a program that reads from the console a sequence of N integer numbers 
//and returns the minimal and maximal of them.


class MinAndMaxNum
{
    static void Main()
    {
        int number;
        int min = int.MaxValue;
        int max = int.MinValue;
        Console.Write("Enter how numbers you would like to enter: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Now enter {0} more numbers: ", n);
        for (int i = 1; i <= n; i++)
        {
            number = int.Parse(Console.ReadLine());
            if (max < number)
            {
                max = number;
            }
            if (min > number)
            {
                min = number;
            }
        }
        Console.WriteLine("Min: : {0}", min);
        Console.WriteLine("Max: {0}", max);

    }
}
    