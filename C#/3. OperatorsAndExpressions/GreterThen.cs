using System;

    class GreterThen
    {
        static void Main()
        {
            Console.Write("a = ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine(firstNum > secondNum ? "a>b" : "a<b"); 

        }
    }
