// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine("Программа получает на вход число N и считает произведение чисел от 1 до N.");
Console.WriteLine("Будете вводить число N самостоятельно? Введите `y` или 'yes' если согласны.");
Console.WriteLine("Если нежелаете , то программа сгенерирует число в диапазоне 1...100.");
string? answer_user = Console.ReadLine();
int num = 0;

// Генерируем рандомное число от 1 до 100.
static int Random_num ()
{
    Random rnd = new Random();
    int num = rnd.Next(1,100);

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
{
    num = Enter_num();
    while (num <= 0)
    {
        Console.WriteLine("Число должно быть положительным и НЕ равняться нулю. Повторите ввод.");
        num = Enter_num();
    }
}
else
{
    num = Random_num();
    Console.WriteLine("Сгененрирогвали число: " + num + ".");
}

// Функция рассчитывает произведение чисел.
int Multi_count (int number)
{
    int multiplicate = 1;
    while (number != 0)
    {
        multiplicate = multiplicate * number;
        number--;
    }
    return multiplicate;
}

// Выполняем рассчет.
Console.WriteLine("Произведение чисел от 1 до " + num + " равно: " + Multi_count(num));