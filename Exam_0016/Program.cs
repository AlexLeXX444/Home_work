// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Программа проверяет, является ли номер дня недели выходным.");
Console.WriteLine("Будете вводить чило самостоятельно? Введите `y` или 'yes' если согласны.");
Console.WriteLine("Если нежелаете , то программа сгенерирует число в диапазоне 1...7.");
string? answer_user = Console.ReadLine();
int num;

// Генерируем рандомное число от 1 до 10000.
static int Random_num ()
{
    Random rnd = new Random();
    int num = rnd.Next(1,7);

    return num;
}

// Считываем ввод пользователя.
static int Enter_num ()
{
    Console.WriteLine("Введите число от 1 до 7:");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

// Заполняем значения для дальнейших расчётов.
if (answer_user == "y" || answer_user == "yes") 
    num = Enter_num(); 
else
    num = Random_num();

// Рассчитываем и выводим данные в консоль.
if (num > 0 && num < 8)
{
    if (num == 6 || num == 7 )
        Console.Write("Выходной день.");
    else
        Console.Write("Рабочий день.");
} else 
    Console.Write("Неверно указан номер дня недели.");