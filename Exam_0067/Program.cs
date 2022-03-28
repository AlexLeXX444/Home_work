// Показать натуральные числа от N до 1, N задано.

Console.WriteLine("Введите число. Оно может положительным или отрицательным, НО не должно равняться единице 1.");
int num = Convert.ToInt32(Console.ReadLine());
num = CheckUserEntries(num);

// Проверяем ввод пользователя.
int CheckUserEntries (int num)
{
    while (num == 1)
    {
        Console.WriteLine("Некорретный ввод. Повторите.");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

// Вывод на консоль положительных чисел.
void ShowNumbersPlus (int num)
{
    if (num < 1)
        return;

    Console.Write($"{num, 3} ");
    ShowNumbersPlus(num - 1);
}

// Вывод на консоль положительных чисел.
void ShowNumbersMinus (int num)
{
    if (num > 1)
        return;

    Console.Write($"{num, 3} ");
    ShowNumbersMinus(num + 1);
}

Console.Clear();
ShowNumbersPlus(num);
ShowNumbersMinus(num);