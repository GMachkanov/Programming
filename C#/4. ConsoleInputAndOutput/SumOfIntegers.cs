using System;

//Write a program that reads 3 integer numbers from the console and prints their sum. Examples:

class SumOfIntegers
{
    static void Main()
    {
        double sum = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.Write("{0}). Number = ", i+1);
            double n = double.Parse(Console.ReadLine());
            sum += n;
        }
        Console.Write("Sum = ");
        Console.WriteLine(sum);
    }
}
