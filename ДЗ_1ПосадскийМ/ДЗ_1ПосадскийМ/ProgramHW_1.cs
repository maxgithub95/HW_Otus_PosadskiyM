Random rnd = new Random(); // Решил сделать размерность таблицы рандомной, так как в задании не просится ввести его с клавиатуры.
int n = rnd.Next(1, 6);    // Как вызвать случайное число нашел на просторах интернета
Console.WriteLine("Размерность таблицы " + n);
string text = "";
while ((text.Length < 1) || ((text.Length + 2*n)>40)) 
{
    if (text.Length < 1)
    {
        Console.WriteLine("Введите произвольный текст");
        text = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Строка слишком длинная");
        Console.WriteLine("Введите произвольный текст");
        text = Console.ReadLine();
    }
}
string Granica = "";
for (int i = 1; i <= (2+(n-1)*2+text.Length); i++)
{
       Granica = Granica + "+";
}
void Gran() { Console.WriteLine(Granica); }
void FirstString()
{ Gran();
    int i = 1;
do
    {
        if (i != n)
        {
            string Stroka = "+";
            for (int j = 1; j <= ((n - 1) * 2 + text.Length); j++)
            {
                 Stroka = Stroka + " ";
            }
            Stroka = Stroka + "+";
            Console.WriteLine(Stroka);
        }
        else 
        {
            string Stroka = "+";
            while (Stroka.Length< (1 + (n - 1) * 2 + text.Length))
            {
                if ((Stroka.Length < n) || (Stroka.Length >= n + text.Length))  Stroka = Stroka + " "; 
                else  Stroka = Stroka + text; 
            }
            Stroka = Stroka + "+";
            Console.WriteLine(Stroka);
        }
        i++;
    }
while (i<= (n - 1) * 2+1);
    Gran();
        }

void SecondString()
{
    string ChetStroka = "+";
    string NeChetStroka = "+";
    for (int i = 1; i <= ((n - 1) * 2 + text.Length); i++)
    {
        if (i % 2 ==0) 
        { ChetStroka = ChetStroka + ' '; NeChetStroka = NeChetStroka + '+'; }
        else { ChetStroka = ChetStroka + '+'; NeChetStroka = NeChetStroka + ' ';}
    }
    ChetStroka = ChetStroka + '+';
    NeChetStroka = NeChetStroka + '+';
    for (int i = 1; i <= (n - 1) * 2+1; i++)
    {
        if (i % 2 == 0) Console.WriteLine(ChetStroka);
        else Console.WriteLine(NeChetStroka);
    }
    Gran();
}

void ThirdString()
{
    string Stroka = "+";
    for (int i = 1; i <= (n - 1) * 2 + text.Length; i++)
    {
        for (int j = 1; j <= (n - 1) * 2 + text.Length; j++)
        {
            Stroka = ((j == i) || ((j + i) == ((n - 1) * 2 + text.Length + 1)))?  Stroka + '+':
            Stroka + ' ';
        }
        Stroka = Stroka + '+';
        Console.WriteLine(Stroka);
        Stroka = "+";
    }
    Gran();
} 
for (int k = 1; k < 4; k++) 
    {
    switch (k)
    {
        case 1:
            FirstString();
            break;
        case 2:
            SecondString();
            break;
        case 3:
            ThirdString();
            break;

    }
}



