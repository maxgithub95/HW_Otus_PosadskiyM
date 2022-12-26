namespace HW_12_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var MyShop = new Shop("MyShop");
            var Customer1 = new Customer("Sylvester Stallone");
            Customer1.Subscribe(MyShop);
            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("Выберите действие:\nA - Добавить товар\nD - Удалить товар\nX - Завершить работу программы");
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.A:
                        MyShop.Add($"Товар от {DateTime.Now}");
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("Введите id товара для удаления из каталога");
                        MyShop.ShowCatalog();
                        bool sucsess = Int32.TryParse(Console.ReadLine(), out int idToRemove);
                        while (!sucsess)
                        {
                            Console.WriteLine("Вы ввели неверный фотмат id, повторите ввод:");
                            sucsess = Int32.TryParse(Console.ReadLine(), out idToRemove);
                        }
                        MyShop.Remove(idToRemove);
                        break;
                    case ConsoleKey.X:
                        break;
                    default:
                        Console.WriteLine("Неверная команда!");
                        break;
                }
            }
            while (key.Key != ConsoleKey.X);
        }
    }
}