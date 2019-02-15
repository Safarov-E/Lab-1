using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers;
            bool flag = false;
            Console.WriteLine("1. Удалить первый четный элемент " +
                            "\n2. Добавить строку с заданным номером " +
                            "\n3. Удалить самую длинную строку " +
                            "\n4. Выход");
            do
            {
                Console.WriteLine();

                do
                {
                    Console.Write("Введите число: ");
                }while (!(int.TryParse(Console.ReadLine(), out numbers)) || numbers <= 0 || numbers >= 5);

                switch (numbers)
                {
                        case 1:
                            Delite();
                            break;
                        case 2:
                            add();
                            break;
                        case 3:
                            Delite_string();
                            break;
                        case 4:
                            flag = true;
                            break;
                    }
               } while (!flag);
        }
        static void Delite()
        {
            int n;
            do
            {
                Console.Write("Введите количество элементов массива: ");
            } while (!(int.TryParse(Console.ReadLine(), out n))|| n <= 0);
            Random rnd = new Random();
            int[] numbers = new int[n];
            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 100);
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");

                if (numbers[i] % 2 != 0)
                {
                   counter++;
                     
                }
            }
            int[] numbers1 = new int[counter];
            for (int i = 0, j = 0; i < numbers.Length; i++)
            {

                if (numbers[i] % 2 != 0)
                {
                    
                    numbers1[j] = numbers[i];
                    j++;
                }
            }
            Console.WriteLine("Удаленные четные элементы");
            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.WriteLine($"numbers[{i}] = {numbers1[i]}");
            }

        }

        static void add()
        {

        }
        static void Delite_string()
        {

        }
    }
}
