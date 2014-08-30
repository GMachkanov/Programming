using System;

//Write an expression that calculates trapezoid's area by given sides a and b and height h

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("TrapezoidArea");
        Console.WriteLine();
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("h = ");
        int h = int.Parse(Console.ReadLine());

        int area = a * b * h / 2;
        Console.WriteLine("Area = " + area);

    }
}
