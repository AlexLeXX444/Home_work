// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.WriteLine("Введите количество строк массива. Число должно быть положительное и больше нуля.");
int str = Convert.ToInt32(Console.ReadLine());
str = UserEnterNum(str);
Console.WriteLine("Введите количество столбцов массива. Число должно быть положительное и больше нуля.");
int stolb = Convert.ToInt32(Console.ReadLine());
stolb = UserEnterNum(stolb);

int[,] massOsn = new int[str,stolb];
double[] massAnswer = new double[stolb];

// Проверяем ввод пользователя.
int UserEnterNum (int n)
{
    while (n < 1)
    {
        Console.WriteLine("Введенное число не соответствует требованиям. Повторите ввод.");
        n = Convert.ToInt32(Console.ReadLine());
    }
    return n;
}

// Заполняем массив рандомными целыми числами.
int[,] RandomNumArray (int[,] mass)
{
    for (int i=0; i<mass.GetLength(0); i++)
    {
        for (int j=0; j<mass.GetLength(1); j++)
            mass[i,j] = new Random().Next(1,10);
    }
    return mass;
}

// Выводим многомерный массив на консоль.
void PrintMultiArray (int[,] mass)
{
    for (int i=0; i<mass.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j=0; j<mass.GetLength(1); j++)
            Console.Write($"{mass[i,j], 5} | ");
        Console.WriteLine();
    }
}

// Выводим линейный массив на консоль.
void PrintArray (double[] mass)
{
    Console.Write("| ");
    for (int i=0; i<mass.Length; i++)
    {
        Console.Write($"{Math.Round(mass[i], 3), 5} | ");
    }
    Console.WriteLine();
}

// Рассчитываем среднее арифметическое по столбцам.
double[] SummArifmetics (double[] mass1, int[,] mass2)
{
    for (int i=0; i<mass2.GetLength(0); i++)
    {
        for (int j=0; j<mass2.GetLength(1); j++)
        {
            mass1[j] = mass1[j] + (double)mass2[i,j];
        }
    }
    
    for (int i=0; i<mass1.Length; i++)
        mass1[i] = mass1[i] / mass2.GetLength(0);

    return mass1;
}

RandomNumArray(massOsn);
PrintMultiArray(massOsn);
Console.WriteLine("Посчитали среднее арифметическое по столбцам и получили:");
PrintArray(SummArifmetics(massAnswer, massOsn));