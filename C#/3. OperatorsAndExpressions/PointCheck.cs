using System;

//Write an expression that checks for given point (x, y) if it is
//within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).


class PointCheck
{
    static void Main()
    {
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("y = ");
        int y = int.Parse(Console.ReadLine());

        if ((x >= -2 && x <= 4) && (y >= -2 && y <= 4))
        {
            if ((x > -1 && x < 5) && (y > 1 && y < 3))
            {
                Console.WriteLine("In rectangle");
            }
            else
            {
                Console.WriteLine("In the circle, but not in rectangle");
            }
        }
    }
}

