// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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

// Сортируем элементы массива построчно по убыванию.
int[,] SortLengthMultiArray (int[,] mass)
{
    for (int s=0; s<mass.GetLength(0); s++)
    {
        int cons = 1;

        while (cons != 0)
        {
            cons = 0;
            for (int i=1; i<mass.GetLength(1); i++)
            {
                if (mass[s,i] > mass[s,i-1])
                {
                    mass[s,i] = mass[s,i] + mass[s,i-1];
                    mass[s,i-1] = mass[s,i] - mass[s,i-1];
                    mass[s,i] = mass[s,i] - mass[s,i-1];
                    cons = 1;
                }
            }
        }
    }

    return mass;
}

FillRandomMultiArray(osnMassive);
Console.Clear();
Console.WriteLine("Получили массив чисел: ");
PrintMultiArray(osnMassive);

SortLengthMultiArray(osnMassive);
Console.WriteLine("Получили массив чисел после замены строк: ");
PrintMultiArray(osnMassive);