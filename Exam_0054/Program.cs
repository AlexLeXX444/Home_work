// В матрице чисел найти сумму элементов главной диагонали

Console.WriteLine("Введите число - это будет размерностью массива. Число должно быть положительное и больше нуля.");
int str = Convert.ToInt32(Console.ReadLine());
UserEnterNum(str);

int[,] mass = new int[str,str];
String[,] outputMass = new string[str,str];

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
            mass[i,j] = new Random().Next(1,100);
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

// Оставляем основную диагональ для вывода в консоль.
String[,] ReplaceElemOfSqaring (int[,] mass)
{
    String[,] outStr = new string[mass.GetLength(0),mass.GetLength(1)];
    for (int i=0; i<mass.GetLength(0); i++)
    {
        for (int j=0; j<mass.GetLength(1); j++)
        {
            if (i == j)
                outStr[i,j] = outStr[i,j] + mass[i,j];
        }
    }
    return outStr;
}

// Выводим многомерный массив на консоль.
void PrintMultiArrayStr (String[,] mass)
{
    for (int i=0; i<mass.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j=0; j<mass.GetLength(1); j++)
            Console.Write($"{mass[i,j], 5} | ");
        Console.WriteLine();
    }
}

// Рассчитываем сумму основной диагонали многомерного массива.
int SummOfDiagonal (int[,] mass)
{
    int n = 0;

    for (int i=0; i<mass.GetLength(0); i++)
    {
        for (int j=0; j<mass.GetLength(1); j++)
        {
            if (i == j)
                n += mass[i,j];
        }
    }

    return n;
}


Console.Clear();
Console.WriteLine("Дан массив: ");
RandomNumArray(mass);
PrintMultiArray(mass);

Console.WriteLine("Основная диагональ:");
PrintMultiArrayStr(ReplaceElemOfSqaring(mass));

Console.WriteLine("Сумма элементов основной диагонали: " + SummOfDiagonal(mass));