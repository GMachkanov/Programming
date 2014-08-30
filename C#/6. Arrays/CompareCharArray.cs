using System;

//Write a program that compares two char arrays lexicographically (letter by letter).


class CompareCharArray
{
    static void Main()
    {
        //string inputArrayOne = Console.ReadLine();
        //string inputArrayTwo = Console.ReadLine();
        ////Transforming the input
        //string[] inputOne = inputArrayOne.Split(' ');
        //string[] inputTwo = inputArrayTwo.Split(' ');

        //int[] arr1 = new int[inputOne.Length];
        //for (int i = 0; i < inputOne.Length; i++)
        //{
        //    arr1[i] = int.Parse(inputOne[i]);
        //}
        //int[] arr2 = new int[inputTwo.Length];
        //for (int i = 0; i < inputTwo.Length; i++)
        //{
        //    arr2[i] = int.Parse(inputTwo[i]);
        //}

        //int counterOfEqualElements = 0;
        //if (arr1.Length != arr2.Length)
        //{
        //    Console.WriteLine("False");
        //}
        //else
        //{
        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        if (arr1[i] == arr2[i])
        //        {
        //            counterOfEqualElements++;
        //        }
        //    }
        //    if (counterOfEqualElements == arr1.Length)
        //    {
        //        Console.WriteLine("True");
        //    }
        //    else
        //    {
        //        Console.WriteLine("False");
        //    }
        //}
        Console.Write("First = ");
        string first = Console.ReadLine();
        Console.Write("Second = ");
        string second = Console.ReadLine();

        if (first.Length != second.Length)
        {
            Console.WriteLine("Words must be with equal LENGHT");
        }
        else
        {
            for (int i = 0; i < first.Length; i++)
            {
                Console.WriteLine("index[{0}] = {1}", i, first[i]);
            }
            for (int i = 0; i < second.Length; i++)
            {
                Console.WriteLine("index[{0}] = {1}", i, second[i]);
            }

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] == second[i])
                {
                    Console.WriteLine("index[{i}] are equal",i);
                }
                else
                {
                    Console.WriteLine("index[{i}] are not equal", i);

                }
            }
        }
        


    }
}


