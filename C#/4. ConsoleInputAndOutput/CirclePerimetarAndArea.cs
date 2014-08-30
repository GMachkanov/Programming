using System;

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. Examples:
//r	    perimeter	area
//2	    12.57	    12.57
//3.5	21.99	    38.48

class CirclePerimetarAndArea
{
    static void Main(string[] args)
    {
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine("Perimetur = {0:F2}" , 2*r*3.14);
        Console.WriteLine("Area = {0:F2}", r * r * 3.14);

    }
}
