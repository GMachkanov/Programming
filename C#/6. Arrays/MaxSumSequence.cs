using System;

////Write a program that finds the sequence of maximal sum in given array. Example:
//    {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//    Can you do it with only one loop (with single scan through the elements of the array)?


class MaxSumSequence
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
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

        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            sum += arrayOfNumbers[i];
            if (sum < 0)
            {
                sum = 0;
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                //Console.Write("{0},",arrayOfNumbers[i]);
            }
        }
        Console.WriteLine();
        Console.WriteLine(maxSum);
    }
}
