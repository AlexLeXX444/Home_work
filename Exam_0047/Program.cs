// Написать программу копирования массива.
int[] mainArray = new int [10];
int[] copyArray = new int [mainArray.Length];

// Заполняем массив рандомными числами.
int[] RandomNumbers (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        mass[i] = new Random().Next(1,10);
    
    return mass;
}

// Вывод массива в консоль.
void PrintArray (int[] mass)
{
    Console.Write("| ");
    for (int i=0; i<mass.Length; i++)
        Console.Write(mass[i] + " | ");
    Console.WriteLine();
}

// Копируем данные из одного массива в другой.
int[] FullCopyArray (int[] mArray, int[] cArray)
{
    for (int i=0; i<mArray.Length; i++)
        cArray[i] = mArray[i];
    
    return cArray;
}

RandomNumbers(mainArray);
FullCopyArray(mainArray, copyArray);
Console.WriteLine("Дан массив: ");
PrintArray(mainArray);
Console.WriteLine("Скопировали в другой массив и получили:");
PrintArray(copyArray);