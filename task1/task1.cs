// Показать числа от а до b.

string NumbersFor(int a, int b) // Решение задачи методом через цикл for
{
    string result = String.Empty; // Задаем пустую строку
    for (int i = a; i <= b; i++)
    {
        result = result + $"{i} "; // В первой итерации 0 + 1, т.к result = пустой (0), а = 1.
    }
    return result;
}

string NumbersRec(int a, int b) // Решение задачи через рекурсию
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b); 
    else return String.Empty;
}

Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10


string Test (int x, int y)
{
    string result = String.Empty;
    for (int i = x; i >= y; i--)
    {
        result = result + $"{i} "; // Это просто вывод строки 
    }
    return result;
}

Console.WriteLine(Test(10, 1));