// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

Console.WriteLine("Введите количество строк многомерного массива. Уточнение: число должно быть положительным и больше единицы!");
int strMass = Convert.ToInt32(Console.ReadLine());
strMass = UserEntries(strMass);
Console.WriteLine("Введите количество столюбцов многомерного массива. Уточнение: число должно быть положительным и больше единицы!");
int stolbMass = Convert.ToInt32(Console.ReadLine());
stolbMass = UserEntries(stolbMass);

int[,] osnMassive = new int[strMass, stolbMass];

// Проверяем ввод пользователя.
int UserEntries (int n)
{
    while (n < 2)
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

// Меняем местами строки и столбцы. 
// Если количество строк НЕ равно количеству столбцов массива - вёрнет старый массив БЕЗ изменений!!!
int[,] ReplaceStringColumnMultiArray (int[,] mass)
{
    if (mass.GetLength(0) == mass.GetLength(1))
    {
        for (int i=0; i<mass.GetLength(0); i++)
        {
            for (int j=0; j<mass.GetLength(1); j++)
            {
                if (i > j)
                {
                    mass[i,j] = mass[i,j] + mass[j,i];
                    mass[j,i] = mass[i,j] - mass[j,i];
                    mass[i,j] = mass[i,j] - mass[j,i];
                }
            }
        }

        return mass;
    } else
        return mass;
}


FillRandomMultiArray(osnMassive);
Console.Clear();
Console.WriteLine("Получили массив чисел: ");
PrintMultiArray(osnMassive);

ReplaceStringColumnMultiArray(osnMassive);
Console.WriteLine("После замены строк со столбцами местами, получили массив чисел: ");
PrintMultiArray(osnMassive);