using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HW_11
{
    public class OtusDictionary
    {
        public Elementes[] element = new Elementes[32];
        public void Add(int key, string value)
        {
            if (value == null) throw new ArgumentNullException("value");
            int hash = key % 32;
            if (element[hash] == null) { element[hash]= new Elementes(key, value); }
            else { throw new ElementFilledException("место занято"); }

        }
        public string Get(int key)
        {
            return "0";
        }
    }

    [Serializable]
    internal class ElementFilledException : Exception
    {
        public ElementFilledException()
        {
        }

        public ElementFilledException(string? message) : base(message)
        {
        }

        public ElementFilledException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ElementFilledException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
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
