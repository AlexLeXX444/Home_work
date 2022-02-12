// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.WriteLine("Определить номер четверти плоскости, в которой находится точка с координатами Х и У.");
Console.WriteLine("Причем координаты X и Y не должны равняться 0.");
Console.WriteLine("Будете вводить координаты самостоятельно? Введите `y` или 'yes' если согласны.");
Console.WriteLine("Если нежелаете , то программа сгенерирует координаты в диапазоне -1000...1000.");
string? answer_user = Console.ReadLine();
int x = 0, y = 0;

// Генерируем рандомное число от -1000 до 1000.
static int Random_num ()
{
    Random rnd = new Random();
    int num = rnd.Next(-1000,1000);

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
    Console.WriteLine("Введите координату Х.");
    x = Enter_num();
    Console.WriteLine("Введите координату Y.");
    y = Enter_num();

    while (x == 0 || y == 0)
    {
        Console.WriteLine("Одна или обе координаты равны нулю. Повторите ввод.");
        Console.WriteLine("Введите координату Х.");
        x = Enter_num();
        Console.WriteLine("Введите координату Y.");
        y = Enter_num();
    }
}
else
{
    while (x == 0 || y == 0)
    {
        x = Random_num();
        y = Random_num();
    }
    Console.WriteLine("Сгенерированы координаты Х = " + x + " и координата Y = " + y + ".");
}


// Рассчитываем и выводим данные в консоль.

if (x > 0 && y > 0)
    Console.WriteLine("I четверть.");
if (x < 0 && y > 0)
    Console.WriteLine("II четверть.");
if (x < 0 && y < 0)
    Console.WriteLine("III четверть.");
if (x > 0 && y < 0)
    Console.WriteLine("IV четверть.");