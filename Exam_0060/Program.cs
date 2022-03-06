// Составить частотный словарь элементов двумерного массива.
// Для примера в задаче используем целочисленный массив.

Console.WriteLine("Введите количество строк многомерного массива. Уточнение: число должно быть положительным и больше нуля!");
int strMass = Convert.ToInt32(Console.ReadLine());
strMass = UserEntries(strMass);
Console.WriteLine("Введите количество столюбцов многомерного массива. Уточнение: число должно быть положительным и больше нуля!");
int stolbMass = Convert.ToInt32(Console.ReadLine());
stolbMass = UserEntries(stolbMass);

int[,] osnMassive = new int[strMass, stolbMass];
double[,] dictionaryNum = new double[strMass * stolbMass,3];

// Проверяем ввод пользователя.
int UserEntries (int n)
{
    while (n < 1)
    {
        Console.WriteLine("Неверное значение. Повторите ввод.");
        n = Convert.ToInt32(Console.ReadLine());
    }

    return n;
}

// Заполним массив рандомными числами.
int[,] FillRandomMultiArray (int[,] mass)
{
    for (int i=0; i<mass.GetLength(0); i++)
    {
        for (int j=0; j<mass.GetLength(1); j++)
            mass[i,j] = new Random().Next(1,10);
    }

    return mass;
}

// Выводим многомерный массив на печать.
void PrintMultiArray (int[,] mass)
{
    Console.Write("| ");
    for (int i=0; i<mass.GetLength(0); i++)
    {
        for (int j=0; j<mass.GetLength(1); j++)
            Console.Write($"{mass[i,j], 5} | ");
        Console.WriteLine();
        if (i != mass.GetLength(0) - 1)
            Console.Write("| ");        
    }
}

// Выводим на печать массив с результатами.
void PrintMultiArrayNoNull (double[,] mass)
{
    Console.WriteLine("| Элемент | Ко-во вхождений | Процент вхождений");
    for (int k=0; k<mass.GetLength(0); k++)
    {
        if (mass[k,1] != 0)
        {
            Console.WriteLine($"| {mass[k,0], 7} | {mass[k,1], 10}      |       {mass[k,2]:f}% ");
        } 

    }
}

// Заполняем словарь встречающимися значениями.
double[,] AddToDictionary (int[,] mass, double[,] dictionary)
{
    int elemNum = 0;
    bool elemIs = true;
    
    for (int i=0; i<mass.GetLength(0); i++)
    {
        for (int j=0; j<mass.GetLength(1); j++)
        {
            elemIs = true;
            for (int k=0; k<elemNum; k++)
            {
                if (dictionary[k,0] == mass[i,j])
                {
                    dictionary[k,1]++;
                    elemIs = false;
                    break;
                }
            }
            if (elemIs)
            {
                dictionary[elemNum,0] = mass[i,j];
                dictionary[elemNum,1]++;                
            }

            elemNum++;
        }
    }

    for (int k=0; k<dictionary.GetLength(0); k++)
    {
        dictionary[k,2] = 100 / (double) dictionary.GetLength(0) * dictionary[k,1];
    }

    return dictionary;
}

FillRandomMultiArray(osnMassive);
Console.Clear();
Console.WriteLine("Получили массив чисел: ");
PrintMultiArray(osnMassive);
Console.WriteLine();
PrintMultiArrayNoNull(AddToDictionary(osnMassive,dictionaryNum));