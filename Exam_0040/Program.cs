// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double[] array = new double [5];

// Заполняем массив рандомными числами.
double[] Random_numbers (double[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        mass[i] = new Random().Next(-10,10) + new Random().NextDouble();
    
    return mass;
}

// Выводим массив на печать.
void Massive_output (double[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        Console.Write(" | " + mass[i]);
    Console.WriteLine(" |");
}

// Ищем максимальный элемент массива.
double Max_element_array (double[] mass)
{
    double max_num = mass[0];

    for (int i = 1; i < mass.Length; i++)
    {
        if (max_num < mass[i])
            max_num = mass[i];
    }
    return max_num;
}

// Ищем минимальный элемент массива.
double Min_element_array (double[] mass)
{
    double min_num = mass[0];

    for (int i = 1; i < mass.Length; i++)
    {
        if (min_num > mass[i])
            min_num = mass[i];
    }
    return min_num;
}

Console.WriteLine("Дан массив: ");
Random_numbers(array);
Massive_output(array);
Console.WriteLine("Максимальный элемент массива равен: " + Max_element_array(array));
Console.WriteLine("Минимальный элемент массива равен: " + Min_element_array(array));
Console.WriteLine("Разница между максимальным элементом массива и минимальным составила: " + (Max_element_array(array) - Min_element_array(array)));