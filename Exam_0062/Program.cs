// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

Console.WriteLine("Введите количество строк массива. Число должно быть положительным и больше 1 !!!");
int massStr = Convert.ToInt32(Console.ReadLine());
massStr = UserEntriesCheck(massStr);
Console.WriteLine("Введите количество столбцов массива. Число должно быть положительным и больше 1 !!!");
int massLine = Convert.ToInt32(Console.ReadLine());
massLine = UserEntriesCheck(massLine);

int[,] massOsn = new int [massStr,massLine];
int[,] massResult = new int [massStr - 1,massLine - 1];
int[] minElement = new int [3];


int UserEntriesCheck (int num)
{
    while (num < 2)
    {
        Console.WriteLine("Неверное значение. Повторите ввод.");
        num = Convert.ToInt32(Console.ReadLine());
    }

    return num;
}

void PrintMultiArray (int[,] mass)
{
    for (int i=0; i<mass.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j=0; j<mass.GetLength(1); j++)
        {
            Console.Write($"{mass[i,j], 3}  |");
        }
        Console.WriteLine();
    }
}

int[,] FillRandomMass (int[,] mass)
{
    for (int i=0; i<mass.GetLength(0); i++)
    {
        for (int j=0; j<mass.GetLength(1); j++)
        {
            mass[i,j] = new Random().Next(1,10);
        }
    }
    return mass;
}

int[] FindMinElemInMass (int[] min, int[,] mass)
{
    min[0] = 2147483647;
    for (int i=0; i<mass.GetLength(0); i++)
    {
        for (int j=0; j<mass.GetLength(1); j++)
        {
            if (min[0] > mass[i,j])
            {
                min[0] = mass[i,j];
                min[1] = i;
                min[2] = j;
            }
        }
    }
    return min;
}

int[,] RemoveStrLine (int[] elem, int[,] resMass, int[,] osnMass)
{
    int k, n;

    for (int i=0; i<resMass.GetLength(0); i++)
    {
        if (i >= elem[1])
            k = i + 1;
        else
            k = i;

        for (int j=0; j<resMass.GetLength(1); j++)
        {
            if (j >= elem[2])
                n = j + 1;
            else 
                n = j;

            resMass[i,j] = osnMass[k,n];
        }
    }

    return resMass;
}

Console.Clear();
FillRandomMass(massOsn);
Console.WriteLine("Получили массив:");
PrintMultiArray(massOsn);
Console.WriteLine();

FindMinElemInMass(minElement, massOsn);
Console.WriteLine($"Нашли минимальный элемент {minElement[0]} с первым вхождением с индексом строки {minElement[1]} и столбца {minElement[2]}.");
Console.WriteLine();

RemoveStrLine(minElement, massResult, massOsn);
Console.WriteLine("Получили массив после удаления строки и столбца в которых нашелся минимальный элемент:");
PrintMultiArray(massResult);