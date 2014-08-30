using System;

//We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence 
//of operators that modifies n to hold the value v at the position p from the binary representation of n.
//Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//n = 5 (00000101), p=2, v=0  1 (00000001)


class IntBitNewInt
{
    static void Main()
    {
        Console.Write("Number n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Number in binary system n = ");
        Console.WriteLine(Convert.ToString(n, 2));


        Console.Write("Bit p = ");
        int p = int.Parse(Console.ReadLine());
        
        Console.Write("Value of bit v = ");
        int v = int.Parse(Console.ReadLine());
        
        if (!(v >= 0 && v <= 1))
        {
            Console.WriteLine("Gre6ni danni"); 
        }

        int mask = v << p;
        int result;

        if (v == 0)
        {
            result = mask & n;
            Console.Write(Convert.ToString(result, 10));
            Console.Write("-->");
            Console.Write(Convert.ToString(result, 2));
        }
        else if (v == 1)
        {
            result = mask | n;
            Console.Write(Convert.ToString(result, 10));
            Console.Write("-->");
            Console.Write(Convert.ToString(result, 2));

        }        
    }
}
