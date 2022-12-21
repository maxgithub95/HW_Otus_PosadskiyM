namespace HW_11
{
    public class ElementFilledException : Exception
    {
        public ElementFilledException(string? message) : base(message)
        {
        }

    }
    public class OtusDictionary
    {
        public Elementes[] element = new Elementes[32];
        public string? this[int key]
        {
            get => Get(key);
            set => Add(key, value);
        }
        public void Add(int key, string value)
        {
            if (value == null) throw new ArgumentNullException();
            int hash = key % element.Length;
            if (element[hash] == null) { element[hash] = new Elementes(key, value); }
            else
            {
                SolutionCollision();
                Add(key, value);
            }
        }

        private void SolutionCollision()
        {
            Elementes[] elementsCopy = element;
            var k = element.Length * 2;
            this.element = new Elementes[k];
            foreach (var item in elementsCopy)
            {
                if (item != null)
                    Add(item.Key, item.Value);
            }
        }

        public string? Get(int key)
        {
            int hash = key % element.Length;
            if (element[hash] == null) { return null; }
            return element[hash].Value;
        }
    }



    public class Elementes
    {
        public Elementes(int key, string value)
        {
            Key = key;
            Value = value;
        }

        public int Key { get; set; }
        public string Value { get; set; }
    }
}
