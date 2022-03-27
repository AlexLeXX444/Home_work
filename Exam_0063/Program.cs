// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента.

Console.WriteLine("Общее количество элементов многомерного массива НЕ должно пивышать 180. ");
Console.WriteLine("Ограничение связано с количеством двузначных чисел. Использованы отрицательные и положительные.");
Console.WriteLine();
Console.WriteLine("Введите количество строк многомерного массива. Число должно быть положительным и больше 1.");
int strArr = Convert.ToInt32(Console.ReadLine());
strArr = UserEntries(strArr);

Console.WriteLine("Введите количество столбцов многомерного массива. Число должно быть положительным и больше 1.");
int collArr = Convert.ToInt32(Console.ReadLine());
collArr = UserEntries(collArr);

Console.WriteLine("Укажите глубину многомерного массива. Число должно быть положительным и больше 1.");
int depthArr = Convert.ToInt32(Console.ReadLine());
depthArr = UserEntries(depthArr);

int[,,] osnArr = new int [strArr,collArr,depthArr];

// Проверяем ввод пользователя.
int UserEntries (int num)
{
    while (num < 2)
    {
        Console.WriteLine("Число несоответствует параметрам. Повторите ввод.");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

// Вывод многомерного массива на кончоль.
void PrintMultiArray (int[,,] mass)
{
    for (int i=0; i<mass.GetLength(2); i++)
    {
        for (int j=0; j<mass.GetLength(0); j++)
        {
            Console.Write("|");
            for (int k=0; k<mass.GetLength(1); k++)
            {
                Console.Write($"Строка {j}, Столбец {k}, Глубина {i} =");
                Console.Write($"{mass[j,k,i], 3} |  ");
            }
            Console.WriteLine();            
        }
        Console.WriteLine();
    }
}

// Проверяем на повтор числа в массиве.
int CheckForReply (int iteral, int[] mass)
{
    int n = new Random().Next(-100,100);
    int counter = 1;
    while (counter != 0)
    {
        counter = 0;
        for (int i = 0; i <= iteral; i++)
        {
            if (n == mass[i] || (n > (-9) && n < 9))
            {
                n = new Random().Next(-100,100);
                counter++;
            }
        }
    }

    return n;
}

// Заполняем массив двузначными НЕ повторяющимися числами.
int[,,] FillMultiArray (int[,,] mass)
{
    int[] results = new int [mass.GetLength(0) * mass.GetLength(1) * mass.GetLength(2)];
    int iterals = 0;

    for (int i=0; i<mass.GetLength(2); i++)
    {
        for (int j=0; j<mass.GetLength(0); j++)
        {
            for (int k=0; k<mass.GetLength(1); k++)
            {
                results[iterals] = CheckForReply(iterals,results);
                mass[j,k,i] = results[iterals];
                iterals++;
            }  
        }
    }

    return mass;
}

if ((strArr * collArr * depthArr) > 180)
    Console.WriteLine("Предупреждал ведь. Количество элементов привысило 180.");
else 
{
    Console.Clear();
    Console.WriteLine($"Получили массив: ");
    FillMultiArray(osnArr);
    PrintMultiArray(osnArr);
}