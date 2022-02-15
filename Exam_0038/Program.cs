// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] array = new int [12];

// Заполняем массив рандомными числами.
int[] Random_numbers (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        mass[i] = new Random().Next(0,100);
    
    return mass;
}

// Выводим массив на печать.
void Massive_output (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        Console.Write(mass[i] + "  ");
    Console.WriteLine();
}

// Рассчитываем сумму нечетных элементов массива.
int Summ_array (int[] mass)
{
    int summa = 0;
    for (int i = 1; i < mass.Length; i++)
    {
        if (i % 2 != 0)
            summa = summa + mass[i];
    }
    return summa;
}

Random_numbers(array);
Console.WriteLine("Получили массив: ");
Massive_output(array);
Console.WriteLine("Сумма нечетных элементов массива равна: " + Summ_array(array));

