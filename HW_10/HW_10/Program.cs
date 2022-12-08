using static System.IO.Path;
namespace HW_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dir1 = Combine("D:", "Otus", "TestDir1");
            string dir2 = Combine("D:", "Otus", "TestDir2");
            Directory.CreateDirectory(dir1);
            Directory.CreateDirectory(dir2);
            byte Amount = 10;
            byte k=0;
            if (!File.Exists(Combine(dir2, $"File{Amount}.txt")))
            {
                while (k != Amount)
                {

                    File.CreateText(Combine(dir1, $"File{k + 1}.txt"));
                    File.CreateText(Combine(dir2, $"File{k + 1}.txt"));
                    k++;
                }
            }
            else Console.WriteLine("Файлы уже созданы");
            var NameOfFiles = Directory.GetFileSystemEntries(dir1);
            foreach (string name in NameOfFiles)
            {
                Console.WriteLine(name);
            }
           
        }
    }
}