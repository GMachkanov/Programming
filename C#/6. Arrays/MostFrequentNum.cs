using System;

//Write a program that finds the most frequent number in an array. Example:
//	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

class MostFrequentNum
{
    static void Main(string[] args)
        {

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
                Console.Write("{0}, ", arrayOfNumbers[i]);
            }
            Console.WriteLine("]");

            int maxEqual = 1;
            int equal = 1;
            int number = 0;
            for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
            {
                equal = 1;
                for (int ii = i + 1; ii < arrayOfNumbers.Length; ii++)
                {
                    if (arrayOfNumbers[i] == arrayOfNumbers[ii])
                    {
                        equal++;
                    }
                }
                if (equal > maxEqual)
                {
                    maxEqual = equal;
                    number = arrayOfNumbers[i];
                }
            }
            Console.WriteLine("EqualNumbers = {0} times and the number is {1}", maxEqual, number);
    }
}
