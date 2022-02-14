// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int [123];

// Заполняем массив рандомными числами.
int[] Random_numbers (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        mass[i] = new Random().Next(0,1000);
    
    return mass;
}

// Выводим массив на печать.
void Massive_output (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        Console.Write(mass[i] + "  ");
    Console.WriteLine();
}

int count = 0;
Random_numbers(array);
Massive_output(array);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 9 && array[i] < 100)
        count++;
}

Console.WriteLine("Число искомых элементов: " + count);