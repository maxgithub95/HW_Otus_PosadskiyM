using System.Collections.Immutable;

namespace HW_12_Jack
{
    public class Program
    {
        static void Main(string[] args)
        {

            ImmutableList<string> Jack = ImmutableList.Create<string>();
            int StartCount = Jack.Count();
            var StartJack = Jack;
            Part1 MyPart1 = new Part1();
            Part2 MyPart2 = new Part2();
            Part3 MyPart3 = new Part3();
            Part4 MyPart4 = new Part4();
            Part5 MyPart5 = new Part5();
            Part6 MyPart6 = new Part6();
            Part7 MyPart7 = new Part7();
            Part8 MyPart8 = new Part8();
            Part9 MyPart9 = new Part9();
            var FinalPoem = MyPart9.AddPart(MyPart8.AddPart(MyPart7.AddPart(MyPart6.AddPart(MyPart5.AddPart(MyPart4.AddPart(MyPart3.AddPart(MyPart2.AddPart(MyPart1.AddPart(Jack)))))))));     
            Console.WriteLine(string.Join("\n", FinalPoem));
            int FinalCount = Jack.Count();
            var FinalJack = Jack;
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Количество элементов в первоначальной коллекции до выполнения кода: {StartCount}");
            Console.WriteLine($"Количество элементов в первоначальной коллекции после выполнения кода: {FinalCount}");
            if (StartJack.SequenceEqual(FinalJack)) Console.WriteLine("Коллекция не изменилась!");
            else Console.WriteLine("Увы, колекция изменилась=(");
            Console.ResetColor();
        }
    }
}