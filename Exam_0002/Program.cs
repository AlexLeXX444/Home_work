﻿// Даны два числа. Показать большее и меньшее число

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 >= num2)
{
    if (num1 > num2)
        Console.WriteLine("Число " + num1 + " больше числа " + num2 + ".");
    else
        Console.WriteLine("Числа равны.");
} else 
    Console.WriteLine("Число " + num1 + " меньше числа " + num2 + ".");