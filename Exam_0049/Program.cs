// Показать двумерный массив размером m×n заполненный вещественными числами.

Console.WriteLine("Введите количество строк массива. Число должно быть положительное и больше нуля.");
int str = Convert.ToInt32(Console.ReadLine());
str = UserEnterNum(str);
Console.WriteLine("Введите количество столбцов массива. Число должно быть положительное и больше нуля.");
int stolb = Convert.ToInt32(Console.ReadLine());
stolb = UserEnterNum(stolb);

double[,] mass = new double[str,stolb];

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

// Заполняем массив рандомными вещественными числами.
double[,] RandomNumArray (double[,] mass)
{
    for (int i=0; i<str; i++)
    {
        for (int j=0; j<stolb; j++)
            mass[i,j] = new Random().Next(1,1000) + new Random().NextDouble();
    }
    return mass;
}

// Выводим многомерный массив на консоль.
void PrintMultiArray (double[,] mass)
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

Console.Clear();
RandomNumArray(mass);
PrintMultiArray(mass);