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
            Task1();
            Console.ReadLine();

        }
        static void Task1()
        {
            int n;
            n = Convert.ToInt16(Console.ReadLine());
            int result = n;
            int remainder = 0;
            string binary_num = null;
            do
            {
                result = result / 2;
                Console.WriteLine($"The result if {result}");
                remainder = result % 2;
                Console.Write($"The remainder is {remainder}");
                binary_num += remainder;
            } while (result != 0);
            Console.Write(binary_num);
        }
    }
}
