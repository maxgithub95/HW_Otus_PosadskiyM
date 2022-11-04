using System.Diagnostics;

namespace ДЗ7
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            int GetFibonachiByNumberRecurs(int n)
            {
                int Fn;
                if ((n == 0) || (n == 1)) { Fn = n; }
                else if (n > 0) 
                {
                    Fn = GetFibonachiByNumberRecurs(n - 1) + GetFibonachiByNumberRecurs(n - 2); 
                }
                else { Fn = GetFibonachiByNumberRecurs(n + 2)-GetFibonachiByNumberRecurs(n + 1); }
                return Fn;
            }
            int GetFibonachiByNumberBine(int n)
            {
                double Fn;
                if ((n == 0) || (n == 1)) { Fn = n; }
                else Fn = (Math.Pow(((1+Math.Sqrt(5))/2),n)- Math.Pow(((1 - Math.Sqrt(5)) / 2), n)) / Math.Sqrt(5);
                return (int)Math.Round(Fn);
             }
            int GetFibonachiByNumberCircle(int n)
            {
                int Fn = 0;
                int F0 = 0;
                int F1 = 1;
                if ((n == 0) || (n == 1)) { Fn = n; }
                else if (n > 0)
                {
                    for (int i=2; i<=n; i++)
                    {
                        Fn = F0 + F1;
                        F0 = F1;
                        F1 = Fn;
                    }
                }
                else {
                    for (int i = -1; i >= n; i--)
                    {
                        Fn = F1 - F0;
                        F1 = F0;
                        F0 = Fn;
                    }
                }
                return Fn;
            }
            while (true)
            {
                int Fib;
                Stopwatch stopwatch = new Stopwatch();
                Console.WriteLine("Введите номер члена последовательности Фибоначи или напишите стоп чтобы завершить программу:");
                string k = Console.ReadLine();
                if (k == "стоп") break;
                bool success = int.TryParse(k, out int n);
                if (success)
                {
                    stopwatch.Start();
                    Fib = GetFibonachiByNumberRecurs(n);
                    stopwatch.Stop();
                    Console.WriteLine($"Число Фибоначи под номером {n} в рекурсии = {Fib}, время : {stopwatch.Elapsed}");
                    stopwatch.Restart();
                    stopwatch.Start();
                    Fib = GetFibonachiByNumberBine(n);
                    stopwatch.Stop();
                    Console.WriteLine($"Число Фибоначи под номером {n} по Бине = {Fib}, время : {stopwatch.Elapsed}");
                    stopwatch.Restart();
                    stopwatch.Start();
                    Fib = GetFibonachiByNumberCircle(n);
                    stopwatch.Stop();
                    Console.WriteLine($"Число Фибоначи под номером {n} в цикле = {Fib}, время : {stopwatch.Elapsed}");
                }
                else
                {
                    Console.WriteLine(k + " - не может быть номером элемента, введите целое число:");
                }

            }
        }
    }
}