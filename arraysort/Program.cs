using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysortbubble
{
    internal class Program
    {
        static int[] Bubble(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Random rnd = new Random();

            Console.WriteLine("Массив до сортировки: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
                Console.Write(array[i] + " ");
            }

            Bubble(array);

            Console.WriteLine();
            Console.WriteLine("Массив после сортировки: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
