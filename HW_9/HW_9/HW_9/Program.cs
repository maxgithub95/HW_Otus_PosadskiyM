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
            imageDownloader.Download();
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
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