using System;

//Write a boolean expression that returns if the bit at position p (counting from 0) 
//in a given integer number v has value of 1. Example: v=5; p=1  false.

class ReturnBit
{
    static void Main()
    {
        Console.Write("Number p = ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Bit v = ");
        int v = int.Parse(Console.ReadLine());
        int mask = 1 << v;

        int result = mask & p;
        int bit = result >> v;
       // Console.WriteLine(bit);

        if (bit == 1)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}
