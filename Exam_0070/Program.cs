// Найти сумму цифр числа

Console.WriteLine("Введите число.");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0)
    number = number * (-1);

// Находим сумму числа.
int SummOfNumber (int num)
{
    if (num < 1)
        return 0;
    
    return SummOfNumber(num/10) + num%10;
}

Console.WriteLine("Получили сумму цифр заданного числа: " + SummOfNumber(number));