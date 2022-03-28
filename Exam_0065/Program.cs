/* 
Спирально заполнить двумерный массив:
```
  1  2  3  4
 12 13 14  5
 11 16 15  6
 10  9  8  7 
```
*/
Console.WriteLine("Введите количество строк массива. Число должно быть положительным и больше 1.");
int strArray = Convert.ToInt32(Console.ReadLine());
strArray = CheckUserEntries(strArray);

Console.WriteLine("Введите количество столбцов массива. Число должно быть положительным и больше 1.");
int colArray = Convert.ToInt32(Console.ReadLine());
colArray = CheckUserEntries(colArray);

int[,] osnArray = new int [strArray,colArray];

// Проверяем ввод пользователя
int CheckUserEntries (int num)
{
    while (num < 2)
    {
        Console.WriteLine("Неверное значение. Повторите ввод.");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

// Выводим массив на консоль.
void PrintMultyArray (int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write($"{mass[i,j], 3} |");
        }
        Console.WriteLine();
    }
}

//Заполняем массив спирально.
int[,] FillSpiralMultyArray (int[,] mass)
{
    int minStr = 0, 
        maxStr = mass.GetLength(0) - 1, 
        minCol = 0, 
        maxCol = mass.GetLength(1) - 1,
        counter = 0;

    while (counter < (mass.GetLength(0) * mass.GetLength(1)))
    {
        for (int i = minCol; i <= maxCol; i++) 
        {
            mass[minStr,i] = counter + 1;
            counter++;
        }
        minStr++;

        for (int i = minStr; i <= maxStr; i++) 
        {
            mass[i,maxCol] = counter + 1;
            counter++;
        }
        maxCol--;

        for (int i = maxCol; i >= minCol; i--) 
        {
            mass[maxStr,i] = counter + 1;
            counter++;
        }
        maxStr--;

        for (int i = maxStr; i >= minStr; i--) 
        {
            mass[i,minCol] = counter + 1;
            counter++;
        }
        minCol++;
    }

    return mass;
}

Console.Clear();
FillSpiralMultyArray(osnArray);

Console.WriteLine("Получили заполненный спиралью массив:");
PrintMultyArray(osnArray);