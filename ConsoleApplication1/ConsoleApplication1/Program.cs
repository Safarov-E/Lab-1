using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool flag = false;
            Console.Write("1. Удалить элемент из массива. \n2. Добавить элемент в массив. \n3. Переставить элементы в массиве. \n4. Поиск элемента в массиве. \n5. Сортировка элементов в массиве. \n6. Выход. \n");
            do
            {
                Console.Write("Введите номер пункта: ");
                while (!(int.TryParse(Console.ReadLine(), out a)) || a <= 0 || a > 6) ;

                switch (a)
                {
                    case 1:
                        Deletion();
                        break;
                    case 2:
                        Adding();
                        break;
                    case 3:
                        Permutation();
                        break;
                    case 4:
                        First_even();
                        break;
                    case 5:
                        Sorting();
                        break;
                    default:
                        flag = true;
                        break;
                }

            } while (!flag);
        }
        static void Deletion()
        {   int vod;
            do
            {
                Console.Write("\nВедите количество элементов: ");
            }while (!(int.TryParse(Console.ReadLine(), out vod)) || vod <= 0);
            
            Random ran = new Random();
            int[] n = new int[vod];            
            for (int i = 0; i < vod; i++)
            {
                n[i] = ran.Next(0, 100);
                Console.WriteLine($"vod[{i}] = {n[i]}");
            }

            int vod2;
            do
            {
                Console.Write("\nВведите количество удаляемых елементов: ");
            }
            while (!(int.TryParse(Console.ReadLine(), out vod2)) || vod2 < 0 || vod2 >= vod);
            
            vod = vod - 1;
            int[] n2 = new int[vod];
            for (int i = 0, j = 0; i < n.Length; i++, j++)
            {
                if (i == vod2)
                {
                    i++;
                }
                if(i > n.Length -1)
                {
                    break;

                }
                n2[j] = n[i];
                 
            }
            for (int i = 0; i < n2.Length; i++)
                Console.WriteLine($"n2[{i}] = {n2[i]}");

        }
         static void Adding()
        {
            int vod;
            do{
                Console.Write("\nВведите количестов элементов");
            }while (!(int.TryParse(Console.ReadLine(), out vod)) || vod <= 0) ;
            Random ran = new Random();
            int[] n = new int[vod];
            for(int i = 0; i < vod; i++)
            {
                n[i] = ran.Next(1, 100);
                Console.WriteLine($"vod[{i}] = {n[i]}");
            }
            int vod2;
            do
            {
                Console.Write("Введите количество добавляемых элементов: ");
            }

        }
            static void Permutation()
            {
                Console.Write("Ведите количество элементов: ");
            }
             static void First_even()
            {
                Console.Write("Ведите количество элементов: ");
            }
             static void Sorting()
            {
                Console.Write("Ведите количество элементов: ");
            }
    }
}
