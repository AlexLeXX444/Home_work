/*
Есть число N. Скольно групп M, можно получить при разбиении всех чисел на группы, так чтобы в одной группе все числа были взаимно просты.

Например для N = 50, M получается 6 

Одно из решений :
```
Группа 1: 1 
Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47 
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
Группа 5: 7 16 24 36 40 
Группа 6: 5 32 48
```
Ещё одно решение:

```
Группа 1: 1 
Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47 
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49 
Группа 4: 8 12 18 20 27 28 30 42 44 45 50 
Группа 5: 16 24 36 40 
Группа 6: 32 48

```
Задача: найти M при заданном N и получить одно из разбиений на группы
N ≤ 10²⁰.
По согласованию с преподавателем ограничили число максимальным значением типа long - 9 223 372 036 854 775 807.


Console.WriteLine("Введите число N для которого будем рассчитывать число групп.");
long number = Convert.ToInt64(Console.ReadLine());
number = CheckUserEntries(number);

// Проверяем ввод пользователя.
long CheckUserEntries (long num)
{
    while (num < 1)
    {
        Console.WriteLine("Число должно быть положительным и больше нуля.");
        num = Convert.ToInt64(Console.ReadLine());
    }
    return num;
}

// Заполним массив значениями и присвоим номера групп.
int[,] FillMultiArray (int num)
{
    int[,] mass = new int [num,2];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        mass[i,0] = i;
        for (int j = 1; j <= i; j++)
        {
            int counter = 2;

        }
    }
}*/

int number = Convert.ToInt32(Console.ReadLine());
//int[] inNumbers = Enumerable.Range(1,10).ToArray();

/* Выводим массив на консоль.
async void PrintArray (int[] arr)
{
    Console.Write("| ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} | ");
    }
    Console.WriteLine();
}*/

// Находим количество групп.
int FindNumberOfGroups(int number)
{
    int groupNumber = (int)Math.Ceiling(Math.Log2(number));       
    return groupNumber;
}

Console.WriteLine($"Всего групп, на которые разбивается данное число: {FindNumberOfGroups(number)}");

/*
using System;
using System.Linq;
                    
public class Program
{
    public static int CalculateGroupsNumber(int numbersSequenceRightBound)
    {
        int groupsNumber = (int)Math.Ceiling(Math.Log2(numbersSequenceRightBound));
        
        if ((int)Math.Pow(2, groupsNumber) == numbersSequenceRightBound)
            groupsNumber++;
        
        return groupsNumber;
    }
    
    public static int[] GetNextGroup(int groupNumber, int groupsQuantity, int numbersSequenceRightBound)
    {
        if (groupNumber != groupsQuantity)
            return Enumerable.Range((int)Math.Pow(2, groupNumber - 1), (int)Math.Pow(2, groupNumber) - (int)Math.Pow(2, groupNumber - 1)).ToArray();
        else
            return Enumerable.Range((int)Math.Pow(2, groupNumber - 1), numbersSequenceRightBound - (int)Math.Pow(2, groupNumber - 1) + 1).ToArray();
    }
    
    public static void Main()
    {
        int numbersSequenceRightBound = 0;
        
        Console.WriteLine("Введите число: ");
        numbersSequenceRightBound = Int32.Parse(Console.ReadLine());
        while (numbersSequenceRightBound <= 0)
        {
            Console.WriteLine("Ошибка: число должно быть положительным!");
            Console.Write("Повторите ввод: ");
            numbersSequenceRightBound = Int32.Parse(Console.ReadLine());
        }
        
        Console.WriteLine($"Количество групп для разбиения: {CalculateGroupsNumber(numbersSequenceRightBound)}");
        for (int i = 1; i <= CalculateGroupsNumber(numbersSequenceRightBound); i++)
            Console.WriteLine($"{i}-я группа: [{String.Join(", ", GetNextGroup(i, CalculateGroupsNumber(numbersSequenceRightBound), numbersSequenceRightBound))}]");
            
        Console.ReadKey(true);
    }
}
*/