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
                Console.WriteLine();
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
        {
            int n;
            do
            {
                Console.Write("\nВедите количество элементов: ");
            } while (!(int.TryParse(Console.ReadLine(), out n)) || n <= 0);
            Random rnd = new Random();
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = rnd.Next(0, 100);
                Console.WriteLine($"n[{i}] = {numbers[i]}");
            }
            Console.Write("Введите номер удаляемого элемента: ");
            int a;
            while (!(int.TryParse(Console.ReadLine(), out a)) || a < 0 || a >= n)
            {
                Console.Write("Введите номер удаляемого элемента: ");
            }
            n = n - 1;
            int[] arr = new int[n];
            for (int i = 0, d = 0; i < numbers.Length; i++, d++)
            {
                if (i == a)
                {
                    i++;
                }
                if (i > numbers.Length - 1)
                {
                    break;
                }
                arr[d] = numbers[i];
            }
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            Console.WriteLine();
            Console.Write("1. Удалить элемент из массива. \n2. Добавить элемент в массив. \n3. Переставить элементы в массиве. \n4. Поиск элемента в массиве. \n5. Сортировка элементов в массиве. \n6. Выход. \n");

        }
        static void Adding()
        {
            int n;
            do
            {
                Console.Write("\nВведите количестов элементов: ");
            } while (!(int.TryParse(Console.ReadLine(), out n)) || n <= 0);
            int[] numbers = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                numbers[i] = rnd.Next(1, 100);
                Console.WriteLine($"n[{i}] = {numbers[i]}");
            }
            Console.Write("Введите количество добавляемых элементов: ");
            int a;
            while (!(int.TryParse(Console.ReadLine(), out a)) || n <= 0)
            {
                Console.Write("Введите количество добавляемых элементов: ");
            }
            int b = n + a;
            int[] arr = new int[b];
            for (int i = 0; i < a; i++)
            {
                arr[i] = rnd.Next(1, 100);
            }
            for (int i = a, c = 0; i < arr.Length; i++)
            {
                arr[i] = numbers[c];
                c++;
            }
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine($"arr[{i}] = {arr[i]}"); ;
            Console.WriteLine();
            Console.Write("1. Удалить элемент из массива. \n2. Добавить элемент в массив. \n3. Переставить элементы в массиве. \n4. Поиск элемента в массиве. \n5. Сортировка элементов в массиве. \n6. Выход. \n");

        }
            static void Permutation()
            {
                int n;
                do
                {
                    Console.Write("\nВедите количество элементов: ");
                } while (!(int.TryParse(Console.ReadLine(), out n)) || n <= 0);
            Random rmd = new Random();
            int[] numbers = new int[n];
            for(int i = 0; i < n; i++)
            {
                numbers[i] = rmd.Next(-10, 10);
                Console.WriteLine($"n[{i}] = {numbers[i]}");
            }
            Console.WriteLine("Положительные элементы переставлены в начало массива, отрицательные - в конец");
            int[] arr = new int[n];
            for(int  i = 0, c = n -1, d = 0, e = 0; d < arr.Length; d++, e++)
            {
                if (numbers[e] < 0)
                {
                    arr[i] = numbers[e];
                    i++;
                }
                else
                {
                    arr[c] = numbers[e];
                    c--;
                }
            }
            for(int i = 0; i < arr.Length; i++)
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            Console.WriteLine();
            Console.Write("1. Удалить элемент из массива. \n2. Добавить элемент в массив. \n3. Переставить элементы в массиве. \n4. Поиск элемента в массиве. \n5. Сортировка элементов в массиве. \n6. Выход. \n");

        }
            static void First_even()
            {
            int n;
            do
            {
                Console.Write("\nВедите количество элементов: ");
            } while (!(int.TryParse(Console.ReadLine(), out n)) || n <= 0);
            Random rnd = new Random();
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = rnd.Next(1, 100);
                Console.WriteLine($"n[{i}] = {numbers[i]}");
            }
            var numbersList = numbers.ToList();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine($"Первый четный элемент в массиве {numbers[i]}");
                    break;
                }
            }
        }

             static void Sorting()
            {
                int n;
                do
                {
                    Console.Write("\nВедите количество элементов: ");
                } while (!(int.TryParse(Console.ReadLine(), out n)) || n <= 0);

            Random rmd = new Random();
            int[] numbers = new int[n];
            for(int i = 0; i < n; i++)
            {
                numbers[i] = rmd.Next(-10, 10);
                Console.WriteLine($"n[{i}] = {numbers[i]}");
            }
            int j;
            for(int i = 1; i < n; i++)
            {
                for(j = n - 1; j >= i; j--)
                {
                    if (numbers[j] < numbers[j - 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j - 1];
                        numbers[j - 1] = temp;
                    }
                }
            }
            Console.WriteLine("Отсортированный массив");
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine($"n[{i}] = {numbers[i]}");
            Console.WriteLine();
            Console.Write("1. Удалить элемент из массива. \n2. Добавить элемент в массив. \n3. Переставить элементы в массиве. \n4. Поиск элемента в массиве. \n5. Сортировка элементов в массиве. \n6. Выход. \n");

        }
    }
}
