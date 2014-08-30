using System;

class PrintSpiralMatrix
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        if (n < 20 && n > 0)
        {
            int[,] spiral = new int[n, n];
            string direction = "right";
            int row = 0;
            int col = 0;
            int number = 1;
            int counter = 1;
            while (number < n * n)
            {
                if (direction == "right")
                {
                    if (col + 1 < n && spiral[row, col+1] == 0)
                    {
                        spiral[row, col] = number;
                        number++;
                        col++;
                    }
                    else
                    {
                        direction = "down";
                        continue;
                    }
                }
                if (direction == "down")
                {
                    if (row + 1 < n && spiral[row + 1, col] == 0)
                    {
                        spiral[row, col] = number;
                        number++;
                        row++;

                    }
                    else
                    {
                        direction = "left";
                        continue;
                    }
                }
                if (direction == "left")
                {
                    if (col - 1 >= 0 && spiral[row , col-1] == 0)
                    {
                        spiral[row, col] = number;
                        number++;
                        col--;

                    }
                    else
                    {
                        direction = "up";
                        continue;
                    }
                }
                if (direction == "up")
                {
                    if (row - 1 >= 0 && spiral[row-1,col] == 0)
                    {
                        spiral[row, col] = number;
                        number++;
                        row--;
                    }
                    else
                    {
                        direction = "right";
                        continue;
                    }
                }
            }
            foreach (var num in spiral)
            {
                Console.Write("{0,2} ",num);
                if (counter % n == 0)
                {
                    Console.WriteLine();
                }
                counter++;
            }
        }
        else
        {
            Console.WriteLine("N < 20");
        }
    }
}