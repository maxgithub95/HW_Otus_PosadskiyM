using System.Security.Cryptography.X509Certificates;

namespace HW_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
                var result = list.Top(30);
                var resultEr = list.Top(101);
            try
            {
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            catch (ArgumentException) { Console.WriteLine("Неверный аргумент!"); }
            try
            {
                foreach (var item in resultEr)
                {
                    Console.WriteLine(item);
                }
            }
            catch (ArgumentException) { Console.WriteLine("Неверный аргумент!"); }
            var people = new List<Person> { 
                new Person(12, "Вася"),
                new Person(15, "Лена"),
                new Person(45, "Федор"),
                new Person(22, "Анна"),
                new Person(13, "Машенька"),
                new Person(95, "Василий")
                };
            var result2 = people.Top(60, Person=>Person.Age);
            var resultEr2 = people.Top(101, Person => Person.Age);
            try
            {
                foreach (var item in result2)
                {
                    Console.WriteLine($"{item.Name} - {item.Age} лет/года");
                }
            }
            catch (ArgumentException) { Console.WriteLine("Неверный аргумент!"); }
            try
            {
                foreach (var item in resultEr2)
                {
                    Console.WriteLine($"{item.Name} - {item.Age} лет/года");
                }
            }
            catch (ArgumentException) { Console.WriteLine("Неверный аргумент!"); }

        }
        public class Person
        {
            public int Age { get; }
            public string Name { get; }
            public Person(int age, string name)
            {
                Age = age;
                Name= name;
            }
        }
    }
}