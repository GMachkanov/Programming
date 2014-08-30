using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            int Discriminant = (int)Math.Pow(b,2) - 4*a*c;
            Console.WriteLine("D = b^2 – 4ac = " + Discriminant);

            if (Discriminant < 0)
            {
                Console.WriteLine("No real number");
            }


            if (Discriminant == 0)
            {
                float Number = -b / (2 * a);
                Console.WriteLine("x1,2 = " + Number);
            }


            if (Discriminant > 0)
            {
                float firstNum = (-b + (float)Math.Pow(Discriminant, 1 / 2)) / (2 * a);
                Console.WriteLine("x1 = (-{0} + {1})/(2*{2})", b, Discriminant, a, + firstNum);
                
                Console.WriteLine("x1 = " + firstNum);


                float secondNum = (-b - (float)Math.Pow(Discriminant, 1 / 2)) / (2 * a);
                Console.WriteLine("x2 = " + secondNum);

            }

        }
    }

