namespace DZ4
{
    class EmptyException : Exception
    {
        public EmptyException(string message)
           : base(message)
        {

        }
    }
    class Stack
    {
        private List<string> Hranilishe = new List<string>();
        public Stack(params string[] m)
        {
            foreach (string s in m)
            {
               Add(s);
            }
        }
        public void Add(string a)
        {
            Hranilishe.Add(a);
        }
        public void Print()
        {
            foreach (string s in Hranilishe)
                Console.Write($"{s} ");
            Console.WriteLine();
        }
        public string Pop()
        {

            if (Size == 0) throw new EmptyException("Стек пустой");
            string s = Top;
            Hranilishe.RemoveAt(Hranilishe.Count - 1);
            return s;

        }
        public int Size
        {
            get { return Hranilishe.Count; }
        }
        public string? Top
        {
            get
            {
                if (Size == 0) return null;
                else return Hranilishe[Hranilishe.Count - 1];
            }
        }
        public static Stack Concat(params Stack[] StArray)
        {
            var itog = new Stack();
            foreach (Stack s in StArray)
            {
                while (s.Size != 0)
                {
                    itog.Add(s.Pop());
                }
            }
            return itog;
        }
    }
    static class StackExtensions
    {
        public static void Merge(this Stack s1, Stack s2)
        {
            while (s2.Size != 0)
            {
                s1.Add(s2.Pop());
            }
        }
    }
    static class Program
    {
        static void Main()
        {
            try
            {
                var s = new Stack("a", "b", "c");
                // size = 3, Top = 'c'
                Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
                var deleted = s.Pop();
                // Извлек верхний элемент 'c' Size = 2
                Console.WriteLine($"Извлек верхний элемент '{deleted}' Size = {s.Size}");
                s.Add("d");
                // size = 3, Top = 'd'
                Console.WriteLine($"size = {s.Size}, Top = '{s.Top}'");
                s.Pop();
                s.Pop();
                s.Pop();
                // size = 0, Top = null
                Console.WriteLine($"size = {s.Size}, Top = {(s.Top == null ? "null" : s.Top)}");
                //s.Pop();
                var St = new Stack("a", "b", "c");
                St.Merge(new Stack("1", "2", "3"));
                St.Print();
                var s5 = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
                s5.Print();

                // в стеке s теперь элементы - "a", "b", "c", "3", "2", "1" <- верхний
            }
            catch (EmptyException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}