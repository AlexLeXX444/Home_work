// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Программа получает на вход два числа. Если первое число кратно второму, то выводит 'Кратно'.");
Console.WriteLine("Если первое число НЕ кратно второму, то выводит остаток от деления.");
Console.WriteLine("Первое число должно быть БОЛЬШЕ второго, иначе выведет предупреждение.");
Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine("Будете вводить чило самостоятельно? Введите `y` или 'yes' если согласны.");
Console.WriteLine("Если нежелаете , то программа сгенерирует число в диапазоне 1...1000.");
string? answer_user = Console.ReadLine();
int num1 = 0, num2 = 1;

// Генерируем рандомное число от 100 до 999.
static int Random_num ()
{
    Random rnd = new Random();
    int num = rnd.Next(1,1000);

    return num;
}

// Считываем ввод пользователя.
static int Enter_num ()
{
    Console.WriteLine("Введите число:");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

// Заполняем значения для дальнейших расчётов.
if (answer_user == "y" || answer_user == "yes")
{ 
    num1 = Enter_num();
    num2 = Enter_num();
}
else
{
    while (num1 <= num2)
    {
        num1 = Random_num();
        num2 = Random_num();
    }
}

// Рассчитываем и выводим данные в консоль.
if (num1 > num2)
{
Console.WriteLine("Получены числа: " + num1 + " и " + num2);
    if ((num1 % num2) == 0)
        Console.WriteLine("Кратное.");
    else 
        Console.WriteLine("Остаток от деления равен: " + (num1 % num2));
}
else
    Console.WriteLine("Первое число меньше или равно второму. Так нельзя.");