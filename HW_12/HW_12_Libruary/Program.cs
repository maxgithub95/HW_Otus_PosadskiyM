using System.Collections.Concurrent;

namespace HW_12_Libruary
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConcurrentDictionary<string, int> Library = new ConcurrentDictionary<string, int>();
            Task.Run(async () =>
            {
                while (true)
                {
                    if (Library.Count > 0)
                    {
                        foreach (var book in Library)
                        {
                            if (book.Value < 100) Library[book.Key]++;
                            else Library.TryRemove(book);
                        }
                    }
                    await Task.Delay(1000);
                }
            });
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Меню:\n1 - добавить книгу;\n2 - вывести список непрочитанного;\n3 - отчистить экран ;\n4 - выйти.\n");
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Введите название книги:");
                        string NameOfBook = Console.ReadLine();
                        if (Library.TryAdd(NameOfBook, 0)) Console.WriteLine($"Добавлена книга {NameOfBook}!");
                        Console.WriteLine();                        
                        break;
                    case ConsoleKey.D2:
                        foreach (var book in Library)
                        {
                            Console.WriteLine($"{book.Key} - {book.Value}%;");                           
                        }
                        Console.WriteLine();
                        break;                    
                    case ConsoleKey.D3:
                        Console.Clear();
                        break;
                    case ConsoleKey.D4:
                        break;
                    default:
                        Console.WriteLine("Неверная команда!");
                        break;

                }
            }
            while (key.Key != ConsoleKey.D4);
           
        }
    }
}