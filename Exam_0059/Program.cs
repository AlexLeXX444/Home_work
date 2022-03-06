// В прямоугольной матрице найти строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк многомерного массива. Уточнение: число должно быть положительным и больше нуля!");
int strMass = Convert.ToInt32(Console.ReadLine());
strMass = UserEntries(strMass);
Console.WriteLine("Введите количество столюбцов многомерного массива. Уточнение: число должно быть положительным и больше нуля!");
int stolbMass = Convert.ToInt32(Console.ReadLine());
stolbMass = UserEntries(stolbMass);

int[,] osnMassive = new int[strMass, stolbMass];
int[] summString = new int[strMass];

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

// Ищем сумму по строкам и записываем в результирующий массив.
int[] LookingForMinimumSummString (int[,] mass,int[] summstr)
{
    for (int i=0; i<mass.GetLength(0); i++)
    {
        for (int j=0; j<mass.GetLength(1); j++)
            summstr[i] = summstr[i] + mass[i,j];
    }

    return summstr;
}

// Выводим многомерный массив и суммы строк на печать.
void PrintMultiArray (int[,] mass,int[] sumMass)
{
    Console.Write("| ");
    for (int i=0; i<mass.GetLength(0); i++)
    {
        for (int j=0; j<mass.GetLength(1); j++)
            Console.Write($"{mass[i,j], 5} | ");
        Console.WriteLine($"Сумма строки: {sumMass[i]}");
        if (i != mass.GetLength(0) - 1)
            Console.Write("| ");        
    }
}

// Выводит на печать номер и минимальную сумму элементов строки из заданного массива.
void PrintMinimumString (int[] mass)
{
    int counter = 2147483647;
    for (int i=0; i<mass.Length; i++)
    {
        if (counter > mass[i])
            counter = mass[i];
    }

    for (int i=0; i<mass.Length; i++)
    {
        if (counter == mass[i])
            Console.WriteLine($"Минимальная сумма элементов найдена в строке {i + 1} и равна {mass[i]}.");
    }
}


FillRandomMultiArray(osnMassive);
LookingForMinimumSummString(osnMassive,summString);
Console.Clear();
Console.WriteLine("Получили массив чисел и посчитали сумму строк: ");
PrintMultiArray(osnMassive, summString);
Console.WriteLine();
PrintMinimumString(summString);