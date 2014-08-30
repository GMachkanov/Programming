using System;

    class RectangleArea
    {
        static void Main()
        {
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());

            int area = a * b;
            Console.WriteLine("Area = a * b = " + area);
        }
    }
