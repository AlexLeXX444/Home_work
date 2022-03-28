// Найти сумму элементов от M до N, N и M заданы

Console.WriteLine("Введите число N. Оно может положительным или отрицательным.");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число М. Оно может положительным или отрицательным, НО не равняться N.");
int numM = Convert.ToInt32(Console.ReadLine());
numM = CheckUserEntries(numM,numN);

// Проверяем ввод пользователя.
int CheckUserEntries (int n1,int n2)
{
    while (n1 == n2)
    {
        Console.WriteLine("Некорретный ввод. Повторите.");
        n1 = Convert.ToInt32(Console.ReadLine());
    }
    return n1;
}

// Находим сумму чисел от M до N. При M > N.
int SummElementsPlus (int numM, int numN)
{
    if (numM < numN)
        return 1;

    return SummElementsPlus(numM - 1, numN) + numM;
}

// Находим сумму чисел от M до N. При M < N.
int SummElementsMinus (int numM, int numN)
{
    if (numM > numN)
        return 1;

    return SummElementsMinus(numM + 1, numN) + numM;
}

if (numM > numN)
    Console.WriteLine(SummElementsPlus(numM,numN)-1);
else
    Console.WriteLine(SummElementsMinus(numM,numN)-1);