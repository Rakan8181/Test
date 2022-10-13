using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task2();
            Console.ReadLine();

        }
        static void Task1()
        {
            int n = Convert.ToInt16(Console.ReadLine());
            int result = n;
            int remainder = 0;
            string binary_num = null;
            string reverse_binary_num = null;
            do
            {
                remainder = result % 2;
                result = result / 2;
                binary_num += remainder;
            } while (result != 0);
            for (int i = binary_num.Length - 1; i > -1; i--)
            {
                reverse_binary_num += binary_num[i];
            }
            Console.WriteLine(reverse_binary_num);
        }
        static void Task2()
        {
            Console.WriteLine("Enter a whole number: ");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another whole number: ");
            int Number2 = Convert.ToInt32(Console.ReadLine());
            int Temp1 = Number1;
            int Temp2 = Number2;
            while (Temp1 != Temp2)
            {
                if (Temp1 > Temp2)
                {
                    Temp1 = Temp1 - Temp2;
                }
                else
                {
                    Temp2 = Temp2 - Temp1;
                }
            }
            int Result = Temp1;
            Console.WriteLine($"{Result} is GCF of {Number1} and {Number2}");

        }
    }
}
