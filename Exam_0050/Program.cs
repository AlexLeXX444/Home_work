// В двумерном массиве n×k заменить четные элементы на противоположные

Console.WriteLine("Введите количество строк массива. Число должно быть положительное и больше нуля.");
int str = Convert.ToInt32(Console.ReadLine());
UserEnterNum(str);
Console.WriteLine("Введите количество столбцов массива. Число должно быть положительное и больше нуля.");
int stolb = Convert.ToInt32(Console.ReadLine());
UserEnterNum(stolb);

int[,] mass = new int[str,stolb];

// Проверяем ввод пользователя.
int UserEnterNum (int n)
{
    while (n < 1)
    {
        Console.WriteLine("Введенное число не соответствует требованиям. Повторите ввод.");
        n = Convert.ToInt32(Console.ReadLine());
    }
    return n;
}

// Заполняем массив рандомными целыми числами.
int[,] RandomNumArray (int[,] mass)
{
    for (int i=0; i<str; i++)
    {
        for (int j=0; j<stolb; j++)
            mass[i,j] = new Random().Next(-1000,1000);
    }
    return mass;
}

// Меняем положительные элементы массива на отрицательные.
int[,] ReplaceElementsInArray (int[,] mass)
{
    for (int i=0; i<str; i++)
    {
        for (int j=0; j<stolb; j++)
        {
            if (mass[i,j] > 0)
                mass[i,j] = mass[i,j] * (-1);
        }            
    }
    return mass;
}

// Выводим многомерный массив на консоль.
void PrintMultiArray (int[,] mass)
{
    Console.WriteLine("Получили массив:");

    for (int i=0; i<str; i++)
    {
        Console.Write("| ");
        for (int j=0; j<stolb; j++)
            Console.Write(mass[i,j] + " | ");
        Console.WriteLine();
    }
}

RandomNumArray(mass);
Console.Clear();
PrintMultiArray(mass);
Console.Write("После замены элементов в массиве. ");
PrintMultiArray(ReplaceElementsInArray(mass));
