using System;

//Write an expression that checks for given integer if its third digit
//(right-to-left) is 7. E. g. 1732  true.

class CheckNum
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("3rd number is " + ((a / 100) % 10));
        Console.WriteLine(((a / 100) % 10) == 7);
    }
}

