using System.Text;
using static System.IO.Path;
namespace HW_10
{
    internal class Program
    {
        static void Main()
        {
            string dir1 = Combine("D:", "Otus", "TestDir1");
            string dir2 = Combine("D:", "Otus", "TestDir2");
            Directory.CreateDirectory(dir1);
            Directory.CreateDirectory(dir2);
            byte Amount = 10;
            byte k = 0;
            if (!File.Exists(Combine(dir2, $"File{Amount}.txt")))
            {
                while (k != Amount)
                {
                    string name = $"File{k + 1}.txt";
                    try
                    {
                        using (var textWriter = File.CreateText(Combine(dir1, name)))
                        {
                            textWriter.WriteLine(name);
                        }
                        using (var textWriter = File.CreateText(Combine(dir2, name)))
                        {
                            textWriter.WriteLine(name);
                        }
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    k++;

                }
                var files = Directory.GetFileSystemEntries(dir1).Concat(Directory.GetFileSystemEntries(dir2));
                foreach (string file in files)
                {
                    WriteData(file);
                }

            }
            else Console.WriteLine("Файлы уже созданы");
            var Files = Directory.GetFileSystemEntries(dir1).Concat(Directory.GetFileSystemEntries(dir2));
            foreach (string file in Files)
            {
                Console.WriteLine(ReadFiles(file));
            }

        }

        static StringBuilder ReadFiles(string path)
        {
            StringBuilder result = new StringBuilder();
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string[] Path = path.Split('\\');
                    string name = Path[Path.Length - 1];
                    string text = reader.ReadLine();
                    string data = reader.ReadLine();
                    result.Append($"{name}: {text} + {data}.");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
            return result;

        }

        static void WriteData(string path)
        {
            try
            {
                using (StreamWriter textWriter = new StreamWriter(path, true))
                {
                    textWriter.WriteLine(DateTime.Now);
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }

        }
    }
}