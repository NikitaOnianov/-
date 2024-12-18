using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] mas = { 9, 2, 6, 4, 5, 8 };
            Console.Write("Введите элементы массива: ");
            var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var mas = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                mas[i] = Convert.ToInt32(parts[i]);
            }


            int[] it = BubbleSort(mas);

            Console.Write("Отсортированный массив: ");
            for (int i = 0; i < it.Length; i++)
            {
                Console.Write($"{it[i]} ");
            }
            Console.ReadKey();
        }
        static int[] BubbleSort(int[] mas)
        {
            int temp;
            for (int i = 0; i < mas.Length - 1; i++)
            {
                for (int j = 0; j < mas.Length - i - 1; j++)
                {
                    if (mas[j + 1] < mas[j])
                    {
                        temp = mas[j + 1];
                        mas[j + 1] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
    }
}
