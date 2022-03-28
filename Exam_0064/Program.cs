// Показать треугольник Паскаля
// Сделать вывод в виде равнобедренного треугольника

Console.WriteLine("Введите количество строк треугольника. Число должно быть положительным и больше 1.");
int strPascal = Convert.ToInt32(Console.ReadLine());
strPascal = UserEntries(strPascal);

int[,] treanglePascal = new int [strPascal,strPascal + strPascal - 1];

// Проверяем ввод пользователя.
int UserEntries (int num)
{
    while (num < 2)
    {
        Console.WriteLine("Некорректный ввод. Повторите.");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

// Вывод многомерного массива на консоль.
void PrintMultiArray (int[,] mass)
{
    string str = " ",
           str2 = "";
    int num = mass.GetLength(0) / 5;

    while (num != 0)
    {
        str = str + " ";
        str2 = str2 + " ";
        num--;
    }

    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (mass[i,j] == 0)
                Console.Write($"{str}");
            else 
                Console.Write($"{mass[i,j]}{str2}");            
        }
        Console.WriteLine();
    }
}

// Заполняем массив по формуле треугольника Паскаля.
int[,] FellMultyArrayPascal (int[,] mass)
{
    int n = mass.GetLength(1) / 2;
    mass[0,n] = 1;
    for (int i = 1; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            if (j == 0 || j == (mass.GetLength(1) - 1))
            {
                if (j == 0)
                    mass[i,j] = mass[i-1,j+1];
                else 
                    mass[i,j] = mass[i-1,j-1];
            }
            else 
            {
                mass[i,j] = mass[i-1,j-1] + mass[i-1,j+1];
            }
        }
    }
    return mass;
}

Console.Clear();
FellMultyArrayPascal(treanglePascal);
PrintMultiArray(treanglePascal);