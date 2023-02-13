using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._6
{
    internal class Program
    {
        private static int number1, number2, number3;
        static void Calculate(int num1, int num2, int num3)
        {
            Console.WriteLine($"{num1/5}");
            Console.WriteLine($"{num2 / 5}");
            Console.WriteLine($"{num3 / 5}");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть перше число");
            Int32.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Введіть друге число");
            Int32.TryParse(Console.ReadLine(), out number2);
            Console.WriteLine("Введіть третє число");
            Int32.TryParse(Console.ReadLine(), out number3);
            Calculate(number1,number2,number3);
            Console.ReadLine();
        }
    }
}
