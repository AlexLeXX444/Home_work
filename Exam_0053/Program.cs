// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

Console.WriteLine("Введите количество строк массива. Число должно быть положительное и больше нуля.");
int str = Convert.ToInt32(Console.ReadLine());
UserEnterNum(str);
Console.WriteLine("Введите количество столбцов массива. Число должно быть положительное и больше нуля.");
int stolb = Convert.ToInt32(Console.ReadLine());
UserEnterNum(stolb);
Console.WriteLine("Введите число, которое будем искать.");
int findingNum = Convert.ToInt32(Console.ReadLine());

int[,] mass = new int[str,stolb];
String[,] outputMass = new string[str,stolb];

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
            mass[i,j] = new Random().Next(1,100);
    }
    return mass;
}

// Находим искомые элементы массива по заданному пользователю числу.
String[,] ReplaceElemOfSqaring (int num, int[,] mass)
{
    String[,] outStr = new string[str,stolb];
    for (int i=0; i<str; i++)
    {
        for (int j=0; j<stolb; j++)
        {
            if (mass[i,j] == num)
                outStr[i,j] = outStr[i,j] + mass[i,j];
            else
                outStr[i,j] = " ";
        }
    }
    return outStr;
}

// Проверяем количество вхождений искомого элемента в массиве.
bool FindingElement (int num, int[,] mass)
{
    bool findElement = false;

    for (int i=0; i<str; i++)
    {
        for (int j=0; j<stolb; j++)
        {
            if (mass[i,j] == num)
            {
                findElement = true;
                break;
            }
        }

    }
    return findElement;
}

// Выводим многомерный массив на консоль.
void PrintMultiArray (int[,] mass)
{
    for (int i=0; i<str; i++)
    {
        Console.Write("| ");
        for (int j=0; j<stolb; j++)
            Console.Write($"{mass[i,j], 5} | ");
        Console.WriteLine();
    }
}

// Выводим многомерный массив на консоль.
void PrintMultiArrayStr (String[,] mass)
{
    for (int i=0; i<str; i++)
    {
        Console.Write("| ");
        for (int j=0; j<stolb; j++)
            Console.Write($"{mass[i,j], 5} | ");
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Дан массив: ");
RandomNumArray(mass);
PrintMultiArray(mass);

if (FindingElement(findingNum, mass))
{
    Console.WriteLine("Отобрали только элементы заданные пользователем: ");
    outputMass = ReplaceElemOfSqaring(findingNum, mass);
    PrintMultiArrayStr(outputMass);
} 
else
    Console.WriteLine("Искомые элементы не найдены в массиве!");