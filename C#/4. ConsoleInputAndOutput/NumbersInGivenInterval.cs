using System;

//Write a program that reads two positive integer numbers and prints how many numbers p exist 
//between them such that the reminder of the division by 5 is 0.

class NumbersInGivenInterval
{
    static void Main()
    {
        Console.Write("Start: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("End: ");
        int end = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write("{0}, ",i);
                counter++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("p = {0}", counter);
    }
}
