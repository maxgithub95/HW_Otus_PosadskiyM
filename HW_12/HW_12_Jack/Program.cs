using System.Collections.Immutable;

namespace HW_12_Jack
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            ImmutableList<string> Empty = ImmutableList.Create<string>();
            Part1 MyPart1 = new Part1();
            Part2 MyPart2 = new Part2();
            Part3 MyPart3 = new Part3();
            Part4 MyPart4 = new Part4();
            Part5 MyPart5 = new Part5();
            Part6 MyPart6 = new Part6();
            Part7 MyPart7 = new Part7();
            Part8 MyPart8 = new Part8();
            Part9 MyPart9 = new Part9();
            MyPart1.AddPart(Empty);
            MyPart2.AddPart(MyPart1.Poem);
            MyPart3.AddPart(MyPart2.Poem);
            MyPart4.AddPart(MyPart3.Poem);
            MyPart5.AddPart(MyPart4.Poem);
            MyPart6.AddPart(MyPart5.Poem);
            MyPart7.AddPart(MyPart6.Poem);
            MyPart8.AddPart(MyPart7.Poem);
            MyPart9.AddPart(MyPart8.Poem);
            Console.WriteLine(string.Join("\n", MyPart9.Poem));

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"Количество элементов в первоначальной коллекции: {Empty.Count}");
            Console.ResetColor();
        }
    }
}