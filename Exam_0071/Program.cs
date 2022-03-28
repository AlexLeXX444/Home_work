// Написать программу вычисления функции Аккермана
Console.WriteLine("Введите число N. Число должно быть положительное.");
int numN = Convert.ToInt32(Console.ReadLine());
numN = CheckUserEntries(numN);
Console.WriteLine("Введите число M. Число должно быть положительное.");
int numM = Convert.ToInt32(Console.ReadLine());
numM = CheckUserEntries(numM);

// Проверяем вод пользователя.
int CheckUserEntries (int n)
{
    while (n < 0)
    {
        Console.WriteLine("Число отрицательное. Повторите ввод.");
        n = Convert.ToInt32(Console.ReadLine());
    }
    return n;
}

int AkkermanFunc (int n, int m)
{
    if (n == 0) 
        return m + 1;

    if (n != 0 && m == 0) 
        return AkkermanFunc(n - 1, 1);
        
    if (n > 0 && m > 0) 
        return AkkermanFunc(n - 1, AkkermanFunc(n, m - 1));

    return AkkermanFunc(n,m);
}

Console.WriteLine("Получили значение для заданных M и N: " + AkkermanFunc(numN,numM));