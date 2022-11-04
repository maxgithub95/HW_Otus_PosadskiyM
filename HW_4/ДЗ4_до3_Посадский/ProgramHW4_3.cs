namespace DZ4_3
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
        public class Item
        {
            public Item Prev { get; }
            public string Value { get; set; }

            public Item(Item prev, string value)
            {
                Prev = prev;
                Value = value;
            }
        }
        private class StackItem
        {
            public int count = 0;
            public string? top = null;
            public Item element = null;

        }

        StackItem stackGen = new StackItem();
        public void Add(string a)
        {
            stackGen.top = a;
            stackGen.count++;
            stackGen.element = new Item(stackGen.element, a);
        }
        public string Pop()
        {

            if (stackGen.count == 0) throw new EmptyException("Стек пустой");
            string s = stackGen.element.Value;
            stackGen.element = stackGen.element.Prev;
            stackGen.count--;
            if (stackGen.count == 0) stackGen.top = null; else stackGen.top = stackGen.element.Value;
            return s;

        }
        public int Size
        {
            get { return stackGen.count; }
        }
        public string? Top
        {
            get { return stackGen.top; }
        }



        public Stack(params string[] m)
        {

            foreach (string s in m) Add(s);

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
    static class ProgramHW4_3
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
                while (St.Size != 0) Console.WriteLine($"{St.Pop()}, size = {St.Size}");
                var s5 = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("А", "Б", "В"));
                while (s5.Size != 0) Console.WriteLine(s5.Pop());

                // в стеке s теперь элементы - "a", "b", "c", "3", "2", "1" <- верхний
            }
            catch (EmptyException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}