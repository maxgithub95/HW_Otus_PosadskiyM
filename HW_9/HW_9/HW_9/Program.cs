using System.Net;

namespace HW_9
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string picutreUri = "https://zastavok.net/download/61117/1920x1200/";
            string Name = "bigimage.jpg";
            var imageDownloader = new ImageDownloader(picutreUri, Name);
            imageDownloader.ImageStarted += StartOfDownloading;
            imageDownloader.ImageCompleted += FinishOfDownloading;
            var TaskDownload = imageDownloader.Download();
            Console.WriteLine("Нажмите клавишу A для выхода или любую другую клавишу для проверки статуса скачивания");
            var key = Console.ReadKey(true);
            while (key.Key != ConsoleKey.A)
            {
                if (TaskDownload.IsCompleted) Console.WriteLine("Картинка загружена");
                else Console.WriteLine("Картинка не загружена");
                key = Console.ReadKey(true);
            }
        }

        private static void FinishOfDownloading()
        {
            Console.WriteLine("Скачивание файла закончилось");
        }

        private static void StartOfDownloading()
        {
            Console.WriteLine("Скачивание файла началось");
        }
    }
}