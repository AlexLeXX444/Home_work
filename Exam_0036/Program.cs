// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] array = new int [12];
int count_plus = 0, count_minus = 0;

// Заполняем массив рандомными числами.
int[] Random_numbers (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        mass[i] = new Random().Next(100,1000);
    
    return mass;
}

// Выводим массив на печать.
void Massive_output (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        Console.Write(mass[i] + "  ");
    Console.WriteLine();
}

Console.WriteLine("Получили массив:");
Random_numbers(array);
Massive_output(array);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        count_plus++;
    else
        count_minus++;
}

Console.WriteLine("Количество положительных элементов: " + count_plus);
Console.WriteLine("Количество отрицательных элементов: " + count_minus);