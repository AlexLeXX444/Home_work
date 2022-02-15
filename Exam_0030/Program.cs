// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine("Программа получает на вход число N и выводит кубы чисел диапазона заканчивающихся на четные цифры.");
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

// Функция рассчитывает куб числа.
int Triple_num (int number)
{
    number = number * number * number;
    return number;
}

// Выполняем рассчет.
for (int i = 2; i <= num; i++)
{
    if ((i % 10) % 2 == 0)
        Console.WriteLine("Куб числа " + i + " равен: " + Triple_num(i));
}