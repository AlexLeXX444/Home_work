// Выяснить являются ли три числа сторонами треугольника.

// Зададим массив для хранения значений сторон. 
int[] triple = new int [3];

// Заполняем массив рандомными числами от 1 до 100.
int[] TripleNum (int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        mass[i] = new Random().Next(1,101);
    
    return mass;
}

// Вывод массива на печать.
void PrintMass (int[] mass)
{
    Console.WriteLine("Получили следующие значения сторон:");
    Console.Write("| ");
    for (int i = 0; i < mass.Length; i++)
        Console.Write(mass[i] + " | ");
    Console.WriteLine();
}

// Рассчет суммы всех элементов массива.
int MassSummAll (int[] mass)
{
    int summOfElements = 0;

    for (int i = 0; i < mass.Length; i++)
        summOfElements = summOfElements + mass[i];
    return summOfElements;
}

// Метод получает элемент массива и сам массив на вход и
// сравнивает полученный элемент с суммой оставшихся.
bool SummVersusOne (int elem, int[] mass)
{
    bool result = false;
    if (elem < MassSummAll(mass) - elem)
        result = true;

    return result;
}

// Выполняем рассчет и заполним счетчик в зависимости от ответов.
TripleNum(triple);
PrintMass(triple);
int counter = 0;
for (int i = 0; i < triple.Length; i++)
{
    if (SummVersusOne(triple[i], triple))
        counter++;
}

if (counter == 3)
    Console.WriteLine("Полученные три числа являются сторонами треугольника!!!");
else
    Console.WriteLine("Полученные три числа НЕ являются сторонами треугольника!!!");