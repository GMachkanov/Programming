using System;

//Write a program that finds the maximal increasing sequence in an array. 
//Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

class MaxIncreasingSequence
{
    static void Main()
    {
        Console.Write("Numbers of integers N = ");
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
        Console.Write("Array [");

        for (int i = 0; i < arrayOfNumbers.Length-1; i++)
        {
            if (arrayOfNumbers[i+1] - arrayOfNumbers[i] == 1)
            {
                if (true)
                {
                    Console.Write("{0}, ", arrayOfNumbers[i]);
                }
                else
                {
                    Console.Write("{0}, ", arrayOfNumbers[i+1]);
                }
            }
        }
        Console.Write("]");

    }
}
