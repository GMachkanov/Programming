using System;

//Write a program that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

class EqualElements
{
    static void Main()
    {

        
        // the maximal sequence of equal elements

        Console.Write("Array of numbers N = ");
        int n = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[n];


        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Array [");
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            if (i==arrayOfNumbers.Length-1)
            {
            Console.Write("{0} ", arrayOfNumbers[i]);

            }
            else
            {
                Console.Write("{0}, ", arrayOfNumbers[i]);
            }
        }
        Console.WriteLine("]");

        int maxEqual = 1;
        int equal = 1;
        int number = 0;
        for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
        {
            if (arrayOfNumbers[i]==arrayOfNumbers[i+1])
            {
                equal++;
                if (equal>maxEqual)
                {
                    maxEqual = equal;
                    number = arrayOfNumbers[i];
                }
            }
        }
        Console.WriteLine("EqualNumbers = {0} times and the number is {1}", maxEqual, number);

    }
}
