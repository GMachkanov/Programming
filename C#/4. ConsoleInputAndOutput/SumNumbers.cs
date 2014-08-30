using System;

//Write a program that enters 5 numbers (given in a single line, separated by a space),
//calculates and prints their sum. 

class SumNumbers
{
    static void Main()
    {
        string n = Console.ReadLine();  // Read string
        double sum = 0;

        string[] nums = n.Split(' '); // Split string by spaces
      

        for (int i = 0; i < nums.Length; i++)
        {
            sum += double.Parse(nums[i]); // Parse string to int
        }
        Console.WriteLine("Sum = {0}",sum);  // Result

    }
}
