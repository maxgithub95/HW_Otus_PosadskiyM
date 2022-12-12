using System.Net;

namespace HW_9
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string picutreUri = "https://zastavok.net/download/61117/1920x1200/";
            string Name = "bigimage.jpg";
            var imageDownload = new ImageDownloader(picutreUri, Name);
            imageDownload.Download();
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadKey();
        }
    }
}