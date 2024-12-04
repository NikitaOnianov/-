using System;

class Program
{
    static void Main(string[] args)
    {
        //int[] nums = { 5, 2, 1, 4, 2, 5 };

        Console.Write("Введите числа через пробел: ");
        string[] input = Console.ReadLine().Split(' ');
        int[] nums = Array.ConvertAll(input, int.Parse);


        foreach (int num in nums)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();

        
        // Найти XOR всех чисел
        int xor = 0;
        foreach (int num in nums)
        {
            xor ^= num;
        }

        // Найти бит, который отличает два числа
        int diffBit = xor & -xor;

        // Разделить числа на две группы и найти XOR для каждой группы
        int num1 = 0, num2 = 0;
        foreach (int num in nums)
        {
            if ((num & diffBit) != 0)
            {
                num1 ^= num;
            }
            else
            {
                num2 ^= num;
            }
        }

        Console.WriteLine($"Уникальные числа: {num1}, {num2}");
    }
}
