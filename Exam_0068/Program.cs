// Показать натуральные числа от M до N, N и M заданы

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

// Вывод на консоль положительных чисел.
void ShowNumbersPlus (int numM, int numN)
{
    if (numM < numN)
        return;

    Console.Write($"{numM, 3} ");
    ShowNumbersPlus(numM - 1, numN);
}

// Вывод на консоль положительных чисел.
void ShowNumbersMinus (int numM, int numN)
{
    if (numM > numN)
        return;

    Console.Write($"{numM, 3} ");
    ShowNumbersMinus(numM + 1, numN);
}

Console.Clear();
ShowNumbersPlus(numM,numN);
ShowNumbersMinus(numM,numN);