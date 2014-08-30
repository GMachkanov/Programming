using System;

//Write a program that calculates N!/K! for given N and K (1<K<N).


class ClaculateFactorial
{
    static void Main()
    {

        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());

        if (((k > 1) && (n > k)))
        {
            Console.WriteLine("Factorial");

            //Factorial for N!
            int sum = 1;
            int num = 1;
            Console.Write("N! = 1 ");
            while (num < n)
            {
                num++;
                sum *= num;
                Console.Write("* {0} ", num);
            }
            Console.Write(" = {0} ", sum);

            Console.WriteLine();

            //Factorial for K!
            int sum2 = 1;
            int num2 = 1;
            Console.Write("K! = 1 ");
            while (num2 < k)
            {
                num2++;
                sum2 *= num2;
                Console.Write("* {0} ", num2);
            }
            Console.Write(" = {0} ", sum2);

            int product = sum / sum2;
            Console.WriteLine();
            Console.WriteLine("N!/K! = " + product);
        }
        else
        {
            Console.WriteLine("Nevalidni danni");
            Console.WriteLine("N > K > 1");
        }
    }
}