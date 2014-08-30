using System;

class DivideByTwoNum
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        if ((a % 5 == 0) && (a % 7 == 0))
        {
            Console.WriteLine("Number is Devided by 7 and 5 without remainder");
        }
        else
        {
            Console.WriteLine("Number can't Devided by 7 and 5 without remainder");

        }



    }
}
 