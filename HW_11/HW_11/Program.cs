namespace HW_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new OtusDictionary();
            //WithoutIndex(dictionary);
            WithIndex(dictionary);

        }

        private static void WithoutIndex(OtusDictionary _dictionary)
        {
            _dictionary.Add(43, "55");
            _dictionary.Add(4, "44");
            _dictionary.Add(11, "1111");
            for (var i = 0; i < _dictionary.element.Length; i++)
            {
                if (_dictionary.Get(i) == null)
                    Console.WriteLine("пусто");
                else Console.WriteLine(_dictionary.Get(i));
            }
        }
        private static void WithIndex(OtusDictionary _dictionary)
        {
            _dictionary[43] = "55";
            _dictionary[4] = "44";
            _dictionary[11] = "1111";
            for (var i = 0; i < _dictionary.element.Length; i++)
            {
                if (_dictionary.Get(i) == null)
                    Console.WriteLine("пусто");
                else Console.WriteLine(_dictionary[i]);
            }
        }
    }
}