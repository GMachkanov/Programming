using System;

//Write a program that allocates array of 20 integers and initializes each element
//by its index multiplied by 5. Print the obtained array on the console.


public class NewArray
{
    static void Main()
    {
    //    Console.Write("Number of integers : ");
    //    int n = int.Parse(Console.ReadLine());
    //    int[] array = new int[n];

    //    for (int i = 0; i < n; i++)
    //    {
    //        Console.Write("arr[{0}] = ", i);
    //        array[i] = int.Parse(Console.ReadLine());
    //    }

    //    foreach (var item in array)
    //    {
    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            Console.Write("Index = " + (i * 5));
    //            Console.Write(", Number = " + array[i]);
    //            Console.WriteLine();
    //        }
    //        break;
    //    }
    //    Console.WriteLine(); 
    //    Console.WriteLine();

    //    //New Array
    //    Console.Write("Number of integers : ");
    //    int nn = int.Parse(Console.ReadLine());
    //    int[] array2 = new int[nn];

    //    for (int ii = 0; ii < nn; ii++)
    //    {
    //        Console.Write("arr[{0}] = ", ii);
    //        array[ii] = int.Parse(Console.ReadLine());
    //    }

    //    foreach (var item in array)
    //    {
    //        for (int ii = 0; ii < array.Length; ii++)
    //        {
    //            Console.Write("Index = " + (ii * 5));
    //            Console.Write(", Number = " + array[ii]);
    //            Console.WriteLine();
    //        }
    //        break;
    //    }

        int[] arrayOfNumbers = new int[20];

        Console.Write("Array [ ");
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            arrayOfNumbers[i] = i;
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

        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            Console.WriteLine("Index[{0}] = {1}",i*5,arrayOfNumbers[i]);
        }
    }
}
