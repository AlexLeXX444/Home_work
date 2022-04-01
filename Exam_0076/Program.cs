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

Реализовал решение, подсказанное Сергеем Каменецким. Каждая строка содержит элементы, взаимно простые (не делящиеся друг на друга).
*/

// Просим пользователя ввести число.
Console.WriteLine("Введите число. ");
long number = Convert.ToInt32(Console.ReadLine());
number = CheckUserEntries(number);

// Проверяем ввод пользователя.
long CheckUserEntries (long num)
{
    while (num < 0)
    {
        Console.WriteLine("Неверный ввод, повторите.");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}

// Находим количество групп.
int FindNumberOfGroups(long number)
{
    return (int)Math.Ceiling(Math.Log2(number));
}

// Добавляем числа в массив для последующего вывода в консоль.
String FindGroup(int groupNumber, long originalNumber)
{
    String toPrint = string.Empty;
    // Проверяем, группа последняя или нет.
    if ((groupNumber + 1) == FindNumberOfGroups(originalNumber)) 
    {
        // Ели группа последняя, то добавляем в строку значения только до нужного нам числа.
        for (long i = (int)Math.Pow(2, groupNumber); i <= originalNumber; i++)
            toPrint = toPrint + " | " + i;
    }
    else
    {
        // Если группа не последняя, то добавляем в массив все значения группы.
        for (long i = (int)Math.Pow(2, groupNumber); i < (int)Math.Pow(2, groupNumber + 1); i++)
            toPrint = toPrint + " | " + i;
    }

    return toPrint;
        
}

Console.Clear();
Console.WriteLine($"Всего групп, на которые разбивается число {number} будет равно: {FindNumberOfGroups(number)}");
Console.WriteLine();

// Выводим группы на консоль.
for (int k = 0; k < FindNumberOfGroups(number); k++)
    Console.WriteLine($"Группа №{k + 1}: {FindGroup(k, number)}"); 