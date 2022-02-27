// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты.

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
            mass[i,j] = new Random().Next(1,10);
    }
    return mass;
}

// Меняем элементы массива на их квадраты согласно задаче.
int[,] ReplaceElemOfSqaring (int[,] mass)
{
    for (int i=0; i<str; i++)
    {
        for (int j=0; j<stolb; j++)
        {
            if (i%2 == 0 && j%2 == 0)
                mass[i,j] = mass[i,j] * mass[i,j];
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
PrintMultiArray(mass);
Console.Write("После замены элементов в массиве. ");
PrintMultiArray(ReplaceElemOfSqaring(mass));