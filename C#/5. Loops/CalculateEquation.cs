using System;

//Write a program that, for a given two integer numbers N and X, 
//calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN


class CalculateEquation
{
    static void Main()
    {
        Console.Write("X = ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());


        double sum = 1.0;
        for (int i = 1; i <= n; i++)
        {
            int sumFac = 1;
            int num = 1;
            while (num < n)
            {
                num++;
                sumFac *= num;
                sum += (sumFac / (double)Math.Pow(x,i));
                //Console.WriteLine(i);
            }
            
        }
        Console.WriteLine(sum);
    }
}
