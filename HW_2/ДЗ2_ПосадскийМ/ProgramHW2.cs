using System.Collections;
using System.Diagnostics;

var CollectionList = new List<int>();
var CollectionArrayList = new ArrayList();
var CollectionLinkedList = new LinkedList<int>();
var stopwatch = new Stopwatch();
FillingCollection();
FindingElement();
Divisibility();
void FillingCollection()
{

    stopwatch.Start();
    for (int i = 1; i <= 1000000; i++)
        CollectionList.Add(i);
    stopwatch.Stop();
    Console.WriteLine("Заполнение коллекции List заняло {0} мс", stopwatch.ElapsedMilliseconds);
    stopwatch.Start();
    for (int i = 1; i <= 1000000; i++)
        CollectionArrayList.Add(i);
    stopwatch.Stop();
    Console.WriteLine("Заполнение коллекции ArrayList заняло {0} мс", stopwatch.ElapsedMilliseconds);
    stopwatch.Start();
    for (int i = 1; i <= 1000000; i++)
        CollectionLinkedList.AddLast(i);
    stopwatch.Stop();
    Console.WriteLine("Заполнение коллекции LinkedList заняло {0} мс", stopwatch.ElapsedMilliseconds);
}
void FindingElement()
{
    // Здесь хотел оформить ввод номера элемента с клавиатуры, но программа выдавала ошибку, что локальная переменная number из цикла не может быть использована как ссылка для элемента. Не понял как это исправить.
    // Console.WriteLine("Введите номер элемента, который необходимо найти");

    // bool success = false;
    //while (!success) 
    // {
    //     success = int.TryParse(Console.ReadLine(), out int int number);
    //     Console.WriteLine("Введено не число, повторите ввод");
    // }
     
    int number = 496753;
    stopwatch.Start();
    int ElemenList = CollectionList[number-1];
    stopwatch.Stop();
    Console.WriteLine("Элемент номер {0} найден, он равен {1}, поиск в коллекции List занял {2} мс", number, ElemenList, stopwatch.ElapsedMilliseconds);
    
    stopwatch.Start();
    object? ElemenArrayList = CollectionArrayList[number - 1];
    stopwatch.Stop();
    Console.WriteLine("Элемент номер {0} найден, он равен {1}, поиск в коллекции ArrayList занял {2} мс", number, ElemenArrayList, stopwatch.ElapsedMilliseconds);

    stopwatch.Start();
    var ElemenLinkedList = CollectionLinkedList.Find(number);
    stopwatch.Stop();
    Console.WriteLine("Элемент {0} найден, поиск в коллекции LinkedList занял {1} мс (в коллекции LinkedList нет номеров)", number, stopwatch.ElapsedMilliseconds);
}
void Divisibility()
{
    int Divider = 777;

    stopwatch.Start();
    foreach (int i in CollectionList)
    {
        if (i%Divider == 0) Console.Write("{0} ", i);
    }
    stopwatch.Stop(); 
    Console.WriteLine();
    Console.WriteLine("Вывод кратных числа 777 из Коллекции List занял {0} мс", stopwatch.ElapsedMilliseconds);

    stopwatch.Start();
    foreach (object i in CollectionArrayList)
    {
        if ((int)i % Divider == 0) Console.Write("{0} ", i);
    }
    stopwatch.Stop();
    Console.WriteLine();
    Console.WriteLine("Вывод кратных числа 777 из Коллекции ArrayList занял {0} мс", stopwatch.ElapsedMilliseconds);

    stopwatch.Start();
    foreach (int i in CollectionLinkedList)
    {
        if (i % Divider == 0) Console.Write("{0} ", i);
    }
    stopwatch.Stop();
    Console.WriteLine();
    Console.WriteLine("Вывод кратных числа 777 из Коллекции LinkedList занял {0} мс", stopwatch.ElapsedMilliseconds);
}