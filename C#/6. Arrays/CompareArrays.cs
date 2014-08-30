using System;

//Write a program that reads two arrays from the console and compares them element by element.

class Program
{
    static void Main()
    {
        //Console.Write("Lenght of array = ");
        //int n = int.Parse(Console.ReadLine());
        //int[] arr = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("new int: ");
        //    arr[i] = int.Parse(Console.ReadLine()); // Vuvejdane na stoinost
        //    Console.Write("Integer: " + arr[i]); // dostupvane na suotvetniq integer
        //    Console.Write(" Index: " + i); // Dostupvane na index
        //    Console.WriteLine();
        //}
        //Console.Write("Array1 = ");
        //foreach (var item in arr)
        //{
        //    Console.Write(item + ", ");
        //}
        //Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
        ////Array2

        ////int m = int.Parse(Console.ReadLine());
        //int[] arr2 = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("new int: ");
        //    arr2[i] = int.Parse(Console.ReadLine()); // Vuvejdane na stoinost
        //    Console.Write("Integer: " + arr2[i]); // dostupvane na suotvetniq integer
        //    Console.Write(" Index: " + i); // Dostupvane na index
        //    Console.WriteLine();
        //}
        //Console.Write("Array2 = ");
        //foreach (var item2 in arr2)
        //{
        //    Console.Write(item2 + ", ");
        //}

        ////Comparison

        //for (int i = 0; i < n; i++)
        //{
        //    if (arr[i] == arr2[i])
        //    {
        //        Console.WriteLine("Arr[{0}]=Arr2[{0}]", i);
        //    }
        //    else if (arr[i] > arr2[i])
        //    {
        //        Console.WriteLine("Arr[{0}]>Arr2[{0}]", i);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Arr[{0}]<Arr2[{0}]", i);
        //    }
        //}
        Console.Write("Numbers of first array N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Numbers of second array M = ");
        int m = int.Parse(Console.ReadLine());

        if (n == m)
        {
            int[] firstArray = new int[n];
            int[] secondArray = new int[m];

            //First Array
            Console.WriteLine();
            Console.WriteLine("First Array");
            Console.WriteLine();
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("index[{0}] = ", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("FirstArray [ ");
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("{0}, ", firstArray[i]);
            }
            Console.WriteLine("]");
            Console.WriteLine();
            //Second Array
            Console.WriteLine("Second Array");
            Console.WriteLine();

            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write("index[{0}] = ", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("FirstArray [ ");
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write("{0}, ", secondArray[i]);
            }
            Console.WriteLine("]");
            Console.WriteLine();

            //compare arrays

            for (int i = 0; i < n; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine("Arrays of index[{0}] are not equal", i);
                }
                else
                {
                    Console.WriteLine("Arrays of index[{0}] are equal",i);
                }
            }
        }
        else
        {
            Console.WriteLine("N must be equal to M");
        }
    }
}
