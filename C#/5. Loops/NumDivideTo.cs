using System;

//Write a program that prints all the numbers from 1 to N, that are
//not divisible by 3 and 7 at the same time.


class NumDivideTo
{
    static void Main()
    {
        Console.Write("Number = ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if (!(i % 7 == 0 && i % 3 == 0))
            {
                Console.Write("{0}, ", i);
            }
        }
    }
}
