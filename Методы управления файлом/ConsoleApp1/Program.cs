using System;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool start = true;
            while (start)
            {
                Console.WriteLine("Меню команд");
                Console.WriteLine("1) Добавить файл");
                Console.WriteLine("2) редактировать файл");
                Console.WriteLine("3) вывести содержимое файла");
                Console.WriteLine("4) удалить файл");
                Console.WriteLine("5) Завершить сеанс");
                Console.Write("Выберите номер действие: ");
                int num = int.Parse(Console.ReadLine());
                
                try
                {
                    switch (num)
                    {
                        case 1: AddFile(); break;
                        case 2: EditFile(); break;
                        case 3: ReadFile(); break;
                        case 4: DelFile(); break;
                        case 5: start = false; break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Процесс завершён.");
                }
            }
        }

        static void AddFile()
        {
            Console.Write("Введите имя файла: ");
            string namefile = Console.ReadLine();
            string path = string.Format(@"C:\Users\VivoBook 15X\Desktop\-\Методы управления файлом\{0}.txt", namefile);
            StreamWriter sw = new StreamWriter(path);
            sw.Close();
        }

        static void EditFile()
        {
            // Открытие файла
            Console.Write("Введите имя файла, который вы хотите редакторовать: ");
            string namefile = Console.ReadLine();
            string path = string.Format(@"C:\Users\VivoBook 15X\Desktop\-\Методы управления файлом\{0}.txt", namefile);
            StreamWriter sw = new StreamWriter(path);
            
            // информация
            Console.WriteLine("Можете переписывать файл. Когда закончите, напишите `выход()` на следующей строке.");


            // Записываем
            string line;
            int i = 1;
            while (true)
            {
                Console.Write("Наменование услуги: ");
                string nameservise = Console.ReadLine();

                Console.Write("Сколько длиться эта услуга в минутах: ");
                int time = int.Parse(Console.ReadLine());

                Console.Write("Стоимость услуги: ");
                float price = float.Parse(Console.ReadLine());
                // Добавление новой услуги.
                line = string.Format("{0}. Наименование услуги: {1}, Длительность: {2}, Цена: {3}",i, nameservise, time, price);
                sw.WriteLine(line);
                i++;

                // Выход
                Console.Write("Желаете завершить работу? [Y/n]: ");
                string o = Console.ReadLine();
                if (o == "Y")
                {
                    // Сохранение и закрытие файла.
                    sw.Close();
                    break;
                }
            }
        }

        static void ReadFile()
        {
            // Открытие файла
            Console.Write("Введите имя файла, который вы хотите посмотреть: ");
            string namefile = Console.ReadLine();
            string path = string.Format(@"C:\Users\VivoBook 15X\Desktop\-\Методы управления файлом\{0}.txt", namefile);
            StreamReader sw = new StreamReader(path);

            String line;
            line = sw.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sw.ReadLine();
            }
            sw.Close();
            Console.ReadLine();

        }

        static void DelFile()
        {
            Console.Write("Введите имя файла для удаления: ");
            string namefile = Console.ReadLine();
            string path = string.Format(@"C:\Users\VivoBook 15X\Desktop\-\Методы управления файлом\{0}.txt", namefile);
            File.Delete(path);
        }
    }
}
