// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] array = new int [12];
int summ_plus = 0,
    summ_minus = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,10);

    if (array[i] > 0)
        summ_plus += array[i];
    else
        summ_minus += array[i];
}

Console.WriteLine("Сумма положительных элементов: " + summ_plus);
Console.WriteLine("Сумма отрицательных элементов: " + summ_minus);