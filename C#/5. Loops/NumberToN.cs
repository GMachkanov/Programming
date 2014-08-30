using System;

//Write a program that prints all the numbers from 1 to N.

class NumberToN
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0}, ", i);
        }

    }
}