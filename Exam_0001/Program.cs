//  По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 / num2 == num2)
    Console.WriteLine("Число " + num1 + " является квадратом числа " + num2 + ".");
else 
    Console.WriteLine("Число " + num1 + " НЕ является квадратом числа " + num2 + ".");