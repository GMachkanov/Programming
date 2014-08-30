using System;

//Write a program that gets two numbers from the console and prints the 
//greater of them. Try to implement this without if statements.

class CompareTwoNumber
{
    static void Main()
    {
        Console.Write("Fist Number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Second Number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int max = firstNumber > secondNumber ? firstNumber : secondNumber;
        Console.WriteLine("Greater number is {0}", max);
    }
}
