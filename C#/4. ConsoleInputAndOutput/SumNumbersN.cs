using System;

//Write a program that enters a number n and after that enters more n numbers
//and calculates and prints their sum. Note that you may need to use a for-loop. 

class SumNumbersN
{
    static void Main()
    {
        Console.Write("Numbers: ");
        int n = int.Parse(Console.ReadLine());
        int count = n;
        double sum = 0;
        double number = 0;
        while (n > 0)
        {
            n--;
            Console.Write("Number {0}: ",count - n);
            number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("Sum = {0}",sum);
    }
}
