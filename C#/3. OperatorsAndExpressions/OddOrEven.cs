using System;

    class OddOrEven
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");

            }
        }
    }
