using System;

//Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
//Use the Euclidean algorithm (find it in Internet).


class GreatestDivisor
{
    static void Main()
    {
        Console.Write("A = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("B = ");
        int b = int.Parse(Console.ReadLine());
        int num;
        if (a < b)
        {
            num = a;
            a = b;
            b = num;
        }
        if (a > b)
        {
            if (a % b == 0)
            {
                Console.WriteLine("{0} is GCD", b);
            }
            else
            {
                int r = a % b;
                Console.WriteLine("A % B = " + r);
                int g = b % r;
                Console.WriteLine("B % r = " + g);
                Console.WriteLine("{0} is GCD", g);
            }
        }
    }
}

