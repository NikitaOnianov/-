using System;
using System.Collections.Generic;

public class SummaryRanges
{
    private List<int[]> intervals;

    public SummaryRanges()
    {
        intervals = new List<int[]>();
    }

    public void AddNum(int value)
    {
        int i = 0;

        // Найти позицию для вставки
        while (i < intervals.Count && intervals[i][1] < value)
        {
            i++;
        }

        // Если значение уже существует, ничего не делаем
        if (i < intervals.Count && intervals[i][0] <= value && value <= intervals[i][1])
        {
            return;
        }

        // Проверяем и объединяем интервалы
        if (i > 0 && intervals[i - 1][1] + 1 >= value)
        {
            intervals[i - 1][1] = Math.Max(intervals[i - 1][1], value);
        }
        else
        {
            intervals.Insert(i, new int[] { value, value });
        }

        // Объединяем с последующими интервалами
        while (i + 1 < intervals.Count && intervals[i][1] + 1 >= intervals[i + 1][0])
        {
            intervals[i][1] = Math.Max(intervals[i][1], intervals[i + 1][1]);
            intervals.RemoveAt(i + 1);
        }
    }

    public int[][] GetIntervals()
    {
        return intervals.ToArray();
    }
}

public class Program
{
    public static void Main()
    {
        var commands = new string[] { "SummaryRanges", "addNum", "getIntervals", "addNum", "getIntervals", "addNum", "getIntervals", "addNum", "getIntervals", "addNum", "getIntervals" };
        var values = new object[][] { new object[] { }, new object[] { 1 }, new object[] { }, new object[] { 3 }, new object[] { }, new object[] { 7 }, new object[] { }, new object[] { 2 }, new object[] { }, new object[] { 6 }, new object[] { } };

        SummaryRanges summaryRanges = new SummaryRanges();
        List<object> output = new List<object>();

        foreach (var command in commands)
        {
            switch (command)
            {
                case "SummaryRanges":
                    summaryRanges = new SummaryRanges();
                    output.Add(null);
                    break;
                case "addNum":
                    summaryRanges.AddNum((int)values[Array.IndexOf(commands, command)][0]);
                    output.Add(null);
                    break;
                case "getIntervals":
                    output.Add(summaryRanges.GetIntervals());
                    break;
            }
        }

        // Выводим результаты
        foreach (var result in output)
        {
            if (result == null)
                Console.WriteLine("null");
            else
                Console.WriteLine("[" + string.Join(", ", (int[][])result) + "]");
        }
    }
}
