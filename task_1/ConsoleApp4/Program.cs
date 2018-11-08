using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            double n;
            while (!(double.TryParse(Console.ReadLine(), out n)) || n <= 0)
            {
                Console.Write("Нельзя вычислить. Введите n: ");
            }
            Console.Write("Введите m: ");
            double m;
            while (!(double.TryParse(Console.ReadLine(), out m)) || m <= 1)
            {
                Console.Write("Нельзя вычислить. Введите m: ");
            }
            double k = (m) / (--n);
            n++;
            Console.WriteLine($"m/--n++ = {k}, n = {n}, m={m}");
            Console.ReadLine();
        }
    }
}
