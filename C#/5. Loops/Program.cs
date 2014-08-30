using System;

//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int k=0;
        for (int y = 0; y < n; y++)
        {
            for (int x = 1; x <= n; x++)
            {
                Console.Write(" {0}", x + k);
            }
            k++;
            Console.WriteLine();
        }
    }
}