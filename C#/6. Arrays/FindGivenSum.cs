using System;

//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
class FindGivenSum
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Sum S = ");
        int s = int.Parse(Console.ReadLine());

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

        int sum = 0;
        int start = 0 ;
        int end = 0;
        for (int i = 0; i < arrayOfNumbers.Length - 1; i++)
        {
            start = i;
            sum = arrayOfNumbers[i];
            for (int ii = i + 1; ii < arrayOfNumbers.Length; ii++)
            {
                end = ii;
                sum += arrayOfNumbers[ii];
                if (sum == s)
                {
                    Console.WriteLine("SUM");
                    break;
                }
            }
            
        }
        //Console.WriteLine("start {0}",start);
        //Console.WriteLine("end {0}", end);

        //for (int i = 3; i < 5; i++)
        //{
        //    Console.Write("{0} ", arrayOfNumbers[i]);
        //}
    }
}

//6
//12
//1
//2
//3
//4
//5
//6
