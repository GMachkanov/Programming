using System;
using System.Numerics;

//Write a program that reads a number N and calculates the sum of the first N members
//of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.


class Fibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger firstFibonacci = 0;
        BigInteger secondFibonacci = 1;
        BigInteger nFibonacci = firstFibonacci + secondFibonacci;
        Console.Write(firstFibonacci + ", " + secondFibonacci + ", " + nFibonacci + ", ");

        for (int b = 3; b <= n; b++)
        {
            firstFibonacci = secondFibonacci;
            secondFibonacci = nFibonacci;
            nFibonacci = firstFibonacci + secondFibonacci;
            Console.Write("{0}, ",nFibonacci);
        }
    }
}

