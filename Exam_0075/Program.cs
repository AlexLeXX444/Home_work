/* Есть два массива info и data. 

Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. Числа идут друг за другом без разделителей. 

Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.

Составить массив десятичных представлений чисел массива data с учётом информации из массива info. 

Пример:
```
входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }

выходные данные:
1, 7, 0, 1
```

Какие ошибки могут возникнуть при обработке наборов данных?
Console.WriteLine("Hello, World!");
*/

int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1};
int[] info = {2, 3, 3, 1};

// Переводим чисол из двоичной системы счисления в десятичную.
int ConvertNumbers (int infoNum, int elementNum, int[] dataNum)
{
    String str = string.Empty;

    for (int i = elementNum; i < (elementNum + infoNum); i++)
        str = str + dataNum[i];

    return Convert.ToInt32(str, 2);
}

// Перезаполним массив info переведенными значениями.
int[] ReFillInfoArray (int[] info, int[] data)
{
    int counter = 0;
    int[] answerArray = new int[info.Length];

    for (int i = 0; i < info.Length; i++)
    {
        answerArray[i] = ConvertNumbers(info[i], counter, data);
        counter += info[i];
    }

    return answerArray;
}

// Вывод массива на консоль.
void PrintArray (int[] mass)
{
    Console.Write("| ");

    for (int i = 0; i < mass.Length; i++)
        Console.Write($"{mass[i], 2} | ");
        
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Массив data: ");
PrintArray(data);
Console.WriteLine("Массив info: ");
PrintArray(info);
Console.WriteLine("После проведения рассчетов:");
info = ReFillInfoArray(info,data);
PrintArray(info);