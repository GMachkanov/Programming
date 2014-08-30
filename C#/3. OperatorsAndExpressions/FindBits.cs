using System;


//Write an expression that extracts from a given integer i the value
//of a given bit number b. Example: i=5; b=2  value=1.


class FindBits
{
    static void Main()
    {
        Console.Write("Bit p = ");
        int p = int.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(p, 2));
        
        
        Console.Write("Number v = ");
        int v = int.Parse(Console.ReadLine());
        //Console.WriteLine(Convert.ToString(v, 2));
        
        
        int mask = 1 << p;
        int maskAndn = mask & v;
        Console.Write("Value = ");
        Console.WriteLine(maskAndn >> p);
    }
}
