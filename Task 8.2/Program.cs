using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8._2
{
    internal class Program
    {
        static void StatusOfKredit(int sum, int kredyt = 700)
        {
            int sumaVnesku;
            int sumaBorgu = kredyt - sum;
            
                if (sumaBorgu < 0)
                {
                    Console.WriteLine($"Сума переплати = {Math.Abs(sumaBorgu)}");
                }

                if (sumaBorgu == 0)
                {
                    Console.WriteLine("Борг відсутній");
                }
                if(sumaBorgu > 0)
                {
                    Console.WriteLine($"Сума боргу = {sumaBorgu}");
                    Console.WriteLine("Введіть суму сплати");
                    Int32.TryParse(Console.ReadLine(), out sumaVnesku);
                    StatusOfKredit(sumaVnesku, sumaBorgu);
                }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int sumaVnesku;
            Console.WriteLine("Введіть суму сплати");

            Int32.TryParse(Console.ReadLine(), out sumaVnesku);

            StatusOfKredit(sumaVnesku);
            Console.ReadLine();
        }
    }
}
