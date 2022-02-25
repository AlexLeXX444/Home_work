// Написать программу преобразования десятичного числа в двоичное
Console.WriteLine("Введите число:");
int userNum = Convert.ToInt32(Console.ReadLine());
int[] answerMass = new int[FindTimesDelTwo(userNum)];

// Рачссчитываем, сколько раз число делится на 2.
int FindTimesDelTwo (int n)
{
    int delTwo = 0;
    while (n > 0)
    {
        n = n / 2;
        delTwo++;
    }    
    return delTwo;
}

// Заполняем массив ответами.
int[] ConvertTwiceNum (int n, int[] mass)
{
    for (int i = FindTimesDelTwo(n) - 1; i >= 0; i--)
    {
        mass[i] = n % 2;
        n = n / 2;
    }
    return mass;
}

// Выводим массив в консоль одной единой строкой.
void PrintMassString (int[] mass)
{
    Console.WriteLine("Получили двоичное число:");
    for (int i = 0; i < mass.Length; i++)
        Console.Write(mass[i]);    
}

// Собираем всё воедино.
ConvertTwiceNum(userNum, answerMass);
PrintMassString(answerMass);