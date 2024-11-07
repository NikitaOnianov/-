using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сортировка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            

            // введите массив
            string a = Console.ReadLine();
            char[] arr = a.ToCharArray();

            // Размер массива
            //int N = mas.Length;
            //Console.WriteLine("Введите размер массива:");
            //int N = Convert.ToInt32(Console.ReadLine()); 

            // создание массива
            //int[] arr = new int[N];

            // ввод данных в массив
            //Console.WriteLine("Введите элементы массива:");
            //for (int i = 0; i < N; i++)
            //{
            //    Console.Write("{0}>", i + 1);
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}


            // важная переменная для сравнения
            int temp = 0;


            // пробежка по массиву
            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    // Сравнение чисел
                    if (int(arr[sort]) > int(arr[sort + 1]))
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        int(arr[sort]) = temp;
                    }
                }
                // Вывод промежуточного действия
                Console.WriteLine($"Шаг {write + 1}");
                for (int i = 0; i < arr.Length; i++)
                    Console.Write(arr[i] + " ");
                Console.WriteLine();
                Console.WriteLine();
            }

            // вывод результата
            Console.WriteLine("Конец:");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");

            Console.ReadKey();
        }
    }
}
