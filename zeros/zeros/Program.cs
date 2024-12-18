using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите числа через пробел: ");
        string[] input = Console.ReadLine().Split(' ');
        int[] nums = Array.ConvertAll(input, int.Parse);

        int FirstIndex = 0; //переменная для сортировки

        // Перемещаем все ненулевые элементы вперед
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[FirstIndex] = nums[i];
                FirstIndex++;
            }
        }

        // Заполняем оставшуюся часть массива нулями
        for (int i = FirstIndex; i < nums.Length; i++)
        {
            nums[i] = 0;
        }

        Console.Write("Результат: ");
        foreach (int i in nums)
        {
            Console.Write($"{i} ");
        }
    }
}
