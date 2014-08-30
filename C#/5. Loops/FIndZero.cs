using System;
using System.Numerics;
/*
 * Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
	N = 10  N! = 3628800  2
	N = 20  N! = 2432902008176640000  4
	Does your program work for N = 50 000?
	Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!
*/

class FIndZero
{
    static void Main()
    {
        Console.Write("N = ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        Console.Write("N! = 1");
        int num = 1;
        BigInteger sum = 1;
        while (num < n)
        {
            num++;
            sum *= num;
            Console.Write(" * {0}",num);
        }
        Console.Write(" = {0} ",sum);

        BigInteger dividerFive = n/5;
        BigInteger dividerFivePower = n / 25;
        Console.WriteLine("N / 5 = " + (dividerFive));
        Console.WriteLine("N / 25 = " + (dividerFivePower));

        BigInteger zeroNumber = dividerFive + dividerFivePower;
        Console.WriteLine("Zero in N! = "+ zeroNumber);
        BigInteger m = (BigInteger)Math.Pow(10, 12);
        Console.Write(sum);
        Console.WriteLine(sum/m);

    }
}
