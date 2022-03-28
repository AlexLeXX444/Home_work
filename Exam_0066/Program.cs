// Показать натуральные числа от 1 до N, N задано.

Console.WriteLine("Введите число. Оно должно быть больше 1.");
int num = Convert.ToInt32(Console.ReadLine());
num = CheckUserEntries(num);

// Проверяем ввод пользователя.
int CheckUserEntries (int num)
{
    while (num < 2)
    {
        Console.WriteLine("Некорретный ввод. Повторите.");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

// Вывод на консоль нужных чисел.
void ShowNumbers (int num)
{
    if (num < 1)
        return;

    ShowNumbers(num - 1);
    Console.Write($"{num, 3} ");
}

ShowNumbers(num);