namespace Dz3
{
    class UnknownOperatorException : Exception
    {
        public UnknownOperatorException(string message)
            : base(message)
        {

        }
    }
    class NoOperatorException : Exception
    {
        public string Instruction = "Укажите в выражении оператор: +, -, *, /";
        public NoOperatorException(string message)
            : base(message)
        {

        }
    }
    class InvalidPatternException : Exception
    {
        public InvalidPatternException(string message)
            : base(message)
        {

        }
    }
    class InvalidOperandException : Exception
    {
        public InvalidOperandException(string message)
            : base(message)
        {

        }
    }
    class Answer13Exception : Exception
    {
        public Answer13Exception(string message)
            : base(message)
        {

        }
    }
    static class Program
    {
        static void Main()
        {
            try
            {
                Calculate();
            }

            catch (Exception e)
            { Console.WriteLine($"В калькуляторе произошла ошибка: {e.Message}"); }
        }
        static void Calculate()
        {


            while (true)
            {
                try
                {
                    int a;
                    int b;
                    Console.WriteLine("Введите выражение");
                    string input = Console.ReadLine().ToLower();
                    if (input == "стоп") break;
                    string[] parts = input.Split(' ');
                    if (parts.Length != 3) throw new InvalidPatternException("Выражение некорректное, попробуйте написать в формате:"); // Как сделать сообщение с переносом строки?
                    var aChar = parts[0].ToCharArray();
                    var bChar = parts[2].ToCharArray();
                    foreach (char c in aChar)
                        if (((int)c < 44) || ((int)c > 57) || ((int)c == 47)) throw new InvalidOperandException($"Операнд {parts[0]} не является числом");
                    foreach (char c in bChar)
                        if (((int)c < 44) || ((int)c > 57) || ((int)c == 47)) throw new InvalidOperandException($"Операнд {parts[2]} не является числом");
                    a = Int32.Parse(parts[0]);
                    b = Int32.Parse(parts[2]);
                    switch (parts[1])
                    {
                        case "+":
                            Sum(a, b);
                            break;
                        case "-":
                            Sub(a, b);
                            break;
                        case "*":
                            Mul(a, b);
                            break;
                        case "/":
                            Div(a, b);
                            break;
                        case "":
                            throw new NoOperatorException("Укажите в выражении оператор: +, -, *, /");
                        default:
                            throw new UnknownOperatorException("Я пока не умею работать с оператором " + parts[1]);
                    }
                }
                catch (Answer13Exception e)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(e.Data["13"]);
                    Console.ResetColor();
                }
                catch (UnknownOperatorException e)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                }
                catch (NoOperatorException e)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(e.Instruction);
                    Console.ResetColor();
                }
                catch (DivideByZeroException)
                {
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Деление на ноль");
                    Console.ResetColor();
                }
                catch (InvalidPatternException e)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(e.Message);
                    Console.WriteLine("a + b");
                    Console.WriteLine("a - b");
                    Console.WriteLine("a * b");
                    Console.WriteLine("a / b");
                    Console.ResetColor();
                }
                catch (InvalidOperandException e)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                }
                catch (OverflowException)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Результат выражения вышел за границы int");
                    Console.ResetColor();
                }
                catch (Exception)
                {
                    Console.WriteLine("Я не смог обработать ошибку");
                    throw;
                }
            }
        }
        static void Sum(int a, int b)
        {

            Console.WriteLine("Ответ: {0} ", a + b);
            if (a + b == 13)
            {
                var E13 = new Answer13Exception("Ответ 13!");
                E13.Data.Add("13", "вы получили ответ 13!");
                throw E13;
            }


        }
        static void Sub(int a, int b)
        {
            Console.WriteLine("Ответ: {0} ", a - b);
            if (a - b == 13)
            {
                var E13 = new Answer13Exception("Ответ 13!");
                E13.Data.Add("13", "вы получили ответ 13!");
                throw E13;
            }
        }
        static void Mul(int a, int b)
        {

            Console.WriteLine("Ответ: {0} ", a * b);
            if (a * b == 13)
            {
                var E13 = new Answer13Exception("Ответ 13!");
                E13.Data.Add("13", "вы получили ответ 13!");
                throw E13;
            }

        }
        static void Div(int a, int b)
        {
            Console.WriteLine("Ответ: {0} ", a / b);
            if (a / b == 13)
            {
                var E13 = new Answer13Exception("Ответ 13!");
                E13.Data.Add("13", "вы получили ответ 13!");
                throw E13;
            }
        }


    }
}
