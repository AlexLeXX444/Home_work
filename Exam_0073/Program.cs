// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

Console.WriteLine("Введите первое число последовательности.");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число последовательности.");
int numB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество чисел, которые требуется отобразить. Должно быть положительным и больше нуля.");
int step = Convert.ToInt32(Console.ReadLine());
step = CheckUserEntries(step);

// Проверяем вод пользователя.
int CheckUserEntries (int n)
{
    while (n < 1)
    {
        Console.WriteLine("Ввод не удовлетворяет требованиям. Повторите.");
        n = Convert.ToInt32(Console.ReadLine());
    }
    return n;
}

// Рассчитываем и выводим числа.
int StepByStep (int a, int b, int st)
{
    if (st == 0)
        return 0;
    Console.Write($"{a + b} | ");
    return StepByStep(b, a + b, st - 1) + (a + b);
}

Console.Write($"| {numA} | {numB} | ");
StepByStep(numA,numB,step);