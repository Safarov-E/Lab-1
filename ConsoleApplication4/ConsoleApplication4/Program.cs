using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк массива: ");
            int n;
            int m;

            while (!(int.TryParse(Console.ReadLine(), out n)) || n <= 0) ;
            Console.Write("Введите количество строк массива: ");

            while (!(int.TryParse(Console.ReadLine(), out m)) || m <= 0);
            Console.Write("Введите количество столбцов массива: ");

            Random rnd = new Random();

            int[,] numbers = new int[n, m];
 


            for(int i = 0; i < n; i++) { 
                for (int j = 0; j < m; j++)
                { 
                    numbers[i, j] = rnd.Next(1, 100);
                    Console.WriteLine($"numbers[{i}, {j}] = {numbers[i, j]}");
               }
            }

            Console.Write("Введите количество добавляемых элементов: ");
            int a;
            while (!(int.TryParse(Console.ReadLine(), out a)) || a <= 0)
            {
                Console.Write("Введите количество добавляемых элементов: ");
            }
            int b = n + a;
            int d = m + a;
            int[,] arr = new int[b, d];
           

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    arr[i, j] = rnd.Next(1, 100);
                }
            }

            for (int i = a, c = 0; i < arr.Length; i++)
            {
                for (int j = a, s = 0; j < arr.Length; j++)
                {
                    arr[i, j] = numbers[c, s];
                    c++;
                    s++;
                    Console.WriteLine($"arr[{i}, {j}] = {arr[i, j]}"); ;
                }
            }
            for (int j = 0; j < arr.Length; j++)
                for (int i = 0; i < arr.Length; i++)
                Console.WriteLine($"arr[{i}, {j}] = {arr[i, j]}"); ;
        }
    }
}
