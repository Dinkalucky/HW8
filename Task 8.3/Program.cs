using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._3
{
    internal class Program
    {
        public static int ways = 1;
        public static int counter = 1;
        public static int clients;
        static void Factorial()
        {
            ++counter;
            ways *= counter;
            
            if (counter < clients)
            {
                Factorial();
            }
            else
            {
                Console.WriteLine($"Є {ways} шляхів доставки товару");
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Скільки у нас клієнтів?");
            Int32.TryParse(Console.ReadLine(), out clients);

            Factorial();
            
            Console.ReadLine();
        }
    }
}
