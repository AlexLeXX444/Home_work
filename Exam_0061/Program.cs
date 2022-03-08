// Найти произведение двух матриц.

Console.WriteLine("Введите количество строк матрицы А. Уточнение: число должно быть положительным и больше нуля!");
int strMatrixA = Convert.ToInt32(Console.ReadLine());
strMatrixA = UserEntries(strMatrixA);
Console.WriteLine("Введите количество столюбцов матрицы А. Уточнение: число должно быть положительным и больше нуля!");
int stolbMatrixA = Convert.ToInt32(Console.ReadLine());
stolbMatrixA = UserEntries(stolbMatrixA);

int[,] matrixA = new int[strMatrixA, stolbMatrixA];

Console.WriteLine("Введите количество строк матрицы B. Уточнение: число должно быть положительным и больше нуля!");
int strMatrixB = Convert.ToInt32(Console.ReadLine());
strMatrixB = UserEntries(strMatrixB);
Console.WriteLine("Введите количество столюбцов матрицы B. Уточнение: число должно быть положительным и больше нуля!");
int stolbMatrixB = Convert.ToInt32(Console.ReadLine());
stolbMatrixB = UserEntries(stolbMatrixB);

int[,] matrixB = new int[strMatrixB, stolbMatrixB];

int[,] matrixResult = new int [strMatrixA,stolbMatrixB];

// Проверяем ввод пользователя.
int UserEntries (int n)
{
    while (n < 1)
    {
        Console.WriteLine("Неверное значение. Повторите ввод.");
        n = Convert.ToInt32(Console.ReadLine());
    }

    return n;
}

// Заполним массив рандомными числами.
int[,] FillRandomMultiArray (int[,] mass)
{
    for (int i=0; i<mass.GetLength(0); i++)
    {
        for (int j=0; j<mass.GetLength(1); j++)
            mass[i,j] = new Random().Next(1,10);
    }

    return mass;
}

// Выводим многомерный массив на печать.
void PrintMultiArray (int[,] mass)
{
    Console.Write("| ");
    for (int i=0; i<mass.GetLength(0); i++)
    {
        for (int j=0; j<mass.GetLength(1); j++)
            Console.Write($"{mass[i,j], 5} | ");
        Console.WriteLine();
        if (i != mass.GetLength(0) - 1)
            Console.Write("| ");        
    }
}

// Рассчитываем произведение матриц.
int[,] MatrixComposition (int[,] matA, int[,] matB, int[,] matRes)
{
    for (int i=0; i<matRes.GetLength(0); i++)
    {
        for (int j=0; j<matRes.GetLength(1); j++)
        {
            matRes[i,j] = 0;
            for (int k=0; k<matA.GetLength(1); k++)
                {
                    matRes[i,j] = matRes[i,j] + matA[i, k] * matB[k, j];
                }
        }
    }
    return matRes;
}

if (stolbMatrixA == strMatrixB)
{
    FillRandomMultiArray(matrixA);
    FillRandomMultiArray(matrixB);
    Console.Clear();
    Console.WriteLine("Получили матрицу А: ");
    PrintMultiArray(matrixA);
    Console.WriteLine();
    Console.WriteLine("Получили матрицу B: ");
    PrintMultiArray(matrixB);
    Console.WriteLine();
    Console.WriteLine("Перемножили матрицы и получили ответ: ");
    PrintMultiArray(MatrixComposition(matrixA, matrixB, matrixResult));
} else
{
    Console.WriteLine("Невозможно выполнить умножение.");
    Console.WriteLine("Число столбцов первой матрицы должно ровняться числу строк второй матрицы.");
}