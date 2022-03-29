// Написать программу возведения числа А в целую стень B

Console.WriteLine("Введите число. Должно быть положительное.");
int numA = Convert.ToInt32(Console.ReadLine());
numA = CheckUserEntries(numA);
Console.WriteLine("Введите степень, в которую вщзведем число. Должно быть положительное.");
int stepB = Convert.ToInt32(Console.ReadLine());
stepB = CheckUserEntries(stepB);

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

// Возводим число в степень.
int RaiseNumber (int num, int step)
{
    if (step == 0)
        return 1;

    return RaiseNumber(num, step - 1) * num;
}

Console.WriteLine(RaiseNumber(numA,stepB));