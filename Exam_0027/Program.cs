// Определить количество цифр в числе

Console.WriteLine("Программа получает на вход число и считает количество цифр в нём.");
Console.WriteLine("Будете вводить число самостоятельно? Введите `y` или 'yes' если согласны.");
Console.WriteLine("Если нежелаете , то программа сгенерирует число в диапазоне -10000...10000.");
string? answer_user = Console.ReadLine();
int num = 0;

// Генерируем рандомное число от -10000 до 10000.
static int Random_num ()
{
    Random rnd = new Random();
    int num = rnd.Next(-10000,10000);

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

// Функция рассчитывает количество цифр в числе.
int Number_count (int number)
{
    int count = 0;
    if (number < 0)
        number = number * (-1);
        
    while (number > 0)
    {
        count++;
        number = number / 10;
    }
    return count;
}

// Выполняем рассчет.
if (num == 0)
    Console.WriteLine("Цифр в заданном числе: 1");
else
    Console.WriteLine("Цифр в заданном числе: " + Number_count(num));