// Показать числа Фибоначчи.

Console.WriteLine("Введите число, до которого будем показывать числа Фибоначчи.");
Console.WriteLine("Число должно быть положительным и желательно больше 2.");
int num = Convert.ToInt32(Console.ReadLine());

// Используем списки, т.к. они динамически могут расширяться.
// Изначально мы не знаем какой длинны будет массив.
// И чтобы не захламлять память, используем списки.
List<int> numMass = new List<int> { 0, 1 };

// Проверяем ввод пользователя. 
// Если отрицательное или меньше двух, то будем просить ввести корректное значение.
int UserEnterNum (int n)
{
    while (n < 1)
    {
        Console.WriteLine("Введенное число не соответствует требованиям. Повторите ввод.");
        n = Convert.ToInt32(Console.ReadLine());
    }

    return n;
}

// Создаём массив и заполняем уго значениями чисел Фибоначчи. 
// Массив динамический, т.к. нет точного значения его длинны.
int[] FillArrayFibo (int n, List<int> numList)
{   
    int counter = 2, i = 1;
    
    while (i <= n)
    {
        numList.Add(counter);

        numList[counter] = numList[counter-1] + numList[counter - 2];
        i = numList[counter] + numList[counter-1];
        counter++;
    }

    int[] mass = numList.ToArray<int>();
    return mass;
}

// Вывод массива в консоль.
void PrintArray (int n,int[] mass)
{
    Console.WriteLine("Числа Фибоначчи до числа " + n);
    Console.Write("| ");
    for (int i=0; i<mass.Length; i++)
        Console.Write(mass[i] + " | ");
    Console.WriteLine();
}

UserEnterNum(num);
PrintArray(num, FillArrayFibo(num, numMass));