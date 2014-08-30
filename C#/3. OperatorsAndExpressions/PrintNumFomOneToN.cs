using System;

    class PrintNumFomOneToN
    {
        static void Main()
        {
            Console.Write("Last number: ");
            int lastNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= lastNum; i++)
            {
                Console.Write(i + ", ");
            }
        }
    }

