// Подсчитать сумму цифр в числе

Console.WriteLine("Программа получает на вход число и считает сумму чисел в нём.");
Console.WriteLine("Будете вводить число самостоятельно? Введите `y` или 'yes' если согласны.");
Console.WriteLine("Если нежелаете , то программа сгенерирует число в диапазоне 1...10000.");
string? answer_user = Console.ReadLine();
int num = 0;

// Генерируем рандомное число от 1 до 10000.
static int Random_num ()
{
    Random rnd = new Random();
    int num = rnd.Next(1,10000);

    return num;
}

// Считываем ввод пользователя.
static int Enter_num ()
{
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

// Заполняем значения для дальнейших расчётов.
if (answer_user == "y" || answer_user == "yes")
    num = Enter_num();
else
{
    num = Random_num();
    Console.WriteLine("Сгененрирогвали число: " + num + ".");
}

// Функция рассчитывает сумму цифр в числе.
int Number_count (int number)
{
    int summ = 0;
    while (number > 0)
    {
        summ = summ + (number % 10);
        number = number / 10;
    }
    return summ;
}

// Выполняем рассчет.
if (num == 0)
    Console.WriteLine("Цифр в заданном числе: 0");
else
    Console.WriteLine("Сумма цифр в заданном числе: " + Number_count(num));