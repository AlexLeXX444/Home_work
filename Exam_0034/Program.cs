// Написать программу замену элементов массива на противоположные

int[] array = new int [12];

// Заполняем массив рандомными числами.
int[] Random_numbers (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        mass[i] = new Random().Next(-10,10);
    
    return mass;
}

// Выводим массив на печать.
void Massive_output (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        Console.Write(mass[i] + "  ");
    Console.WriteLine();
}

Console.WriteLine("Заполнили массив рандомными эдементами от -10 до 10:");
Random_numbers(array);
Massive_output(array);

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * (-1);
}

Console.WriteLine("После замены элементов на противоположные получили массив:");
Massive_output(array);