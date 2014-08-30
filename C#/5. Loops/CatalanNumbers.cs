using System;

//In the combinatorial mathematics, the Catalan numbers
//are calculated by the following formula: Cn = (2n)!/((n+1)!*n!)


class CatalanNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        decimal n = decimal.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("n >= 0");
        }
        else
        {
            decimal sum = 1;
            decimal num = 1;
            while (num <= (2 * n))
            {
                sum *= num;
                num++;
            }
            Console.WriteLine("(2*n)! = " + sum);

            decimal sum2 = 1;
            decimal num2 = 1;
            while (num2 <= (1 + n))
            {
                sum2 *= num2;
                num2++;
            }
            Console.WriteLine("(1 + n)! = " + sum2);


            decimal sum3 = 1;
            decimal num3 = 1;
            while (num3 <= n)
            {
                sum3 *= num3;
                num3++;
            }
            Console.WriteLine("n! = " + sum3);
            decimal result = sum / (sum2 * sum3);
            Console.WriteLine("Cn = (2n)!/((n+1)!*n!) = " + result);
        }
    }
}