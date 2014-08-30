using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to convert hexadecimal numbers to binary numbers (directly).

namespace _5.HexadecimalToBinari
{
    class HexadecimalToBinari
    {
        static void Main()
        {
            Console.Write("Hexadecimal = ");
            string hex = Console.ReadLine();
            int sum = 0;
            int lenght = hex.Length;
            for (int i = 0; i < hex.Length; i++)
            {
                if (hex[i] == '1')
                {
                    sum += (int)Math.Pow(16, (lenght - i - 1));
                }
                if (hex[i] == '2')
                {
                    sum += 2*(int)Math.Pow(16, (lenght - i - 1));
                }
                if (hex[i] == '3')
                {
                    sum += 3*(int)Math.Pow(16, (lenght - i - 1));
                }
                if (hex[i] == '4')
                {
                    sum += 4*(int)Math.Pow(16, (lenght - i - 1));
                }
                if (hex[i] == '5')
                {
                    sum += 5 * (int)Math.Pow(16, (lenght - i - 1));
                }
                if (hex[i] == '6')
                {
                    sum += 6 * (int)Math.Pow(16, (lenght - i - 1));
                }
                if (hex[i] == '7')
                {
                    sum += 7 * (int)Math.Pow(16, (lenght - i - 1));
                }
                if (hex[i] == '8')
                {
                    sum += 8 * (int)Math.Pow(16, (lenght - i - 1));
                }
                if (hex[i] == '9')
                {
                    sum += 9 * (int)Math.Pow(16, (lenght - i - 1));
                }
                if (hex[i] == 'a')
                {
                    sum += 10 * (int)Math.Pow(16, (lenght - i - 1));
                }
                if (hex[i] == 'b')
                {
                    sum += 11 * (int)Math.Pow(16, (lenght - i - 1));
                }
                if (hex[i] == 'c')
                {
                    sum += 12 * (int)Math.Pow(16, (lenght - i - 1));
                }
                if (hex[i] == 'd')
                {
                    sum += 13 * (int)Math.Pow(16, (lenght - i - 1));
                }
                if (hex[i] == 'e')
                {
                    sum += 14 * (int)Math.Pow(16, (lenght - i - 1));
                }
                if (hex[i] == 'f')
                {
                    sum += 15 * (int)Math.Pow(16, (lenght - i - 1));
                }
            }
            Console.WriteLine(sum);
            Console.WriteLine();
            int devide = 0;
            int ost = 0;
            List<int> intList = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                devide = sum / 2;
                ost = sum % 2;
                sum = devide;
                intList.Add(ost);
                if (sum == 0)
	                {
		                 break;
	                }
            }
            intList.Reverse();
            Console.Write("Binary = ");
            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write("{0}",intList[i]);
            }
        }
    }
}
