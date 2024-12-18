using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Ввод начальных данных
        Console.Write("Введите время начала каждого занятия через запятую (hh:mm): ");
        var strstart = Console.ReadLine().Split(' ');
        string[] startTimes = new string[strstart.Length];

        for (int i = 0; i < startTimes.Length; i++)
        {
            startTimes[i] = strstart[i].Trim();
        }

        // Продолжительность занятий
        Console.Write("Введите продолжительность каждого занятия через запятую в минутах: ");
        var strdurations = Console.ReadLine().Split(' ');
        int[] durations = new int[strdurations.Length];

        for (int i = 0; i < durations.Length; i++)
        {
            durations[i] = int.Parse(strdurations[i]);
        }

        // Начало работы
        Console.Write("Введите начало рабочего дня (hh:mm): ");
        string beginWorkingTime = Console.ReadLine();

        // Конец рабочего дня
        Console.Write("Введите конец рабочего дня (hh:mm): ");
        string endWorkingTime = Console.ReadLine();

        // Введите время консультации
        Console.Write("Введите время консультаци в минутах: ");
        int consultationTime = int.Parse(Console.ReadLine());

        // Вызов функции для поиска свободных промежутков
        TimeSpan workStart = TimeSpan.Parse(beginWorkingTime);
        TimeSpan workEnd = TimeSpan.Parse(endWorkingTime);
        TimeSpan consultationDuration = TimeSpan.FromMinutes(consultationTime);

        List<string> freeSlots = new List<string>();
        TimeSpan current = workStart;

        for (int i = 0; i < startTimes.Length; i++)
        {
            TimeSpan start = TimeSpan.Parse(startTimes[i]);
            TimeSpan end = start.Add(TimeSpan.FromMinutes(durations[i]));

            // Добавляем свободные промежутки перед занятым временем
            while (current.Add(consultationDuration) <= start)
            {
                freeSlots.Add($"{current:hh\\:mm}-{current.Add(consultationDuration):hh\\:mm}");
                current = current.Add(consultationDuration);
            }

            // Обновляем текущее время до конца текущего занятого промежутка
            current = end > current ? end : current;
        }

        // Проверка на оставшийся свободный промежуток после последнего занятого интервала
        while (current.Add(consultationDuration) <= workEnd)
        {
            freeSlots.Add($"{current:hh\\:mm}-{current.Add(consultationDuration):hh\\:mm}");
            current = current.Add(consultationDuration);
        }

        Console.WriteLine("Свободные временные промежутки:");
        foreach (string slot in freeSlots)
        {
            Console.WriteLine(slot);
        }
    }
}
