using System;

////Sorting an array means to arrange its elements in increasing order. 
//Write a program to sort an array. Use the "selection sort" algorithm: 
//Find the smallest element, move it at the first position, find the smallest
//from the rest, move it at the second position, etc.


class SortArray
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
        int min,tmp;

        for (int i = 0; i < arrayOfNumbers.Length-1; i++)
        {
            min = i;
            for (int ii = i+1; ii < arrayOfNumbers.Length; ii++)
            {
                if (arrayOfNumbers[ii] < arrayOfNumbers[min])
                {
                    min = ii;
                }
            }
            tmp = arrayOfNumbers[i];
            arrayOfNumbers[i] = arrayOfNumbers[min];
            arrayOfNumbers[min] = tmp;
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
    }
}
