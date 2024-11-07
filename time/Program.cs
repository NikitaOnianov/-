using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time
{
    internal class Program
    {
        static void Main(string[] args)
        {
             //Пример данных
             //var dateTimes = new DateTime[] {
             //DateTime.Parse("2023-01-01 08:15"),
             //DateTime.Parse("2023-01-01 08:30"),
             //DateTime.Parse("2023-01-01 08:45"),
             //DateTime.Parse("2023-01-01 09:00"),
             //DateTime.Parse("2023-01-01 09:15"),
             //DateTime.Parse("2023-01-01 09:30"),
             //DateTime.Parse("2023-01-01 09:45"),
             //DateTime.Parse("2023-01-01 10:00"),
             //DateTime.Parse("2023-01-01 10:15"),
            
            
            
            //DateTime x30 = new DateTime(2001, 9, 11, 8, 00, 0);

            int[] a = { 2001, 9, 11, 8, 00, 0 };
            DateTime x30 = DateTime.Parse(a);

            bool us = false;

            for (int i = 0; i < 20; i++)
            {
                if ()
                
                
                if (us)
                {
                    Console.Write($"{x30:t} - ");
                    x30 = x30.AddMinutes(30);
                    Console.WriteLine($"{x30:t}");
                }
                else
                {
                    x30 = x30.AddMinutes(30);
                }
            }
            Console.ReadKey();
        }
    }
}
