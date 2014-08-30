using System;

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

class Program
{
    static void Main()
    {

        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());

        int[] arrayOfNumbers = new int[n];

        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Array [");
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            if (i == arrayOfNumbers.Length - 1)
            {
                Console.Write("{0} ", arrayOfNumbers[i]);
            }
            else
            {
                Console.Write("{0}, ", arrayOfNumbers[i]);
            }
        }
        Console.WriteLine("]");

        int maxSum = 0;
        int sum = 0;

        for (int i = 0; i < arrayOfNumbers.Length - k+1 ; i++)
        {
            sum = arrayOfNumbers[i];
            for (int ii = i + 1; ii < k + i; ii++)
            {
                sum += arrayOfNumbers[ii];
            }
            if (sum > maxSum)
            {
                maxSum = sum;
            }
            sum = 0;
        }
        Console.WriteLine();
        Console.WriteLine("MaxSum = {0}",maxSum);
    }
}
