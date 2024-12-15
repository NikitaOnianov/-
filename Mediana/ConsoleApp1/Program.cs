using System;

internal class Program
{
    static void Main(string[] args)
    {
        //ввод исходного массива
        Console.Write("Введите элементы массива через пробел: ");
        string[] str = Console.ReadLine().Split(' ');
            
        //вызов функции добавления массива 
        int[] arr = AddNum(str);

        // Сортировка массива
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

         //вызов функции нахлождения медианы
         double MediaFinder = FindMedian(arr);

         //вывод результата 
         Console.Write($"Медиана равна = {MediaFinder}");
    }


     static double FindMedian(int[] arr) //нахождение медианы
     {
        double sum = 0;
        double result = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr.Length % 2 == 0) //если длина массива четная, то мы должны найти среднее значение двух средних чисел 
            {
                 int mid1 = arr[arr.Length / 2 - 1];
                 int mid2 = arr[arr.Length / 2];
                 return (mid1 + mid2) / 2.0;
            }
            else // если нечетная длинна массива, то заносим просто средний элемент массива
            {
                return arr[arr.Length / 2];
            }
        }
        return result;
     }


     //функция добавления числа в исходный массив
     static int[] AddNum(string[] str)
     {
         // создаем новый массив с новым размером
         int[] arr = new int[str.Length];

         for (int i = 0; i < arr.Length; i++)
         {
             arr[i] = Convert.ToInt32(str[i]);
         }
         return arr;
     }
}
