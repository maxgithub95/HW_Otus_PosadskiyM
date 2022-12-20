namespace HW_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new OtusDictionary();
            dictionary.Add(43, "55");
            dictionary.Add(4, "44");
            dictionary.Add(11, "1111");
            for (var i = 0; i< dictionary.element.Length; i ++)
            {
                if (dictionary.Get(i) == null)
                    Console.WriteLine("пусто");
                else Console.WriteLine(dictionary.Get(i));
            }
            
        }
    }
}