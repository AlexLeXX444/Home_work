// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Программы получает на вход номер четверти. Выводит возможный диапазон координат.");
Console.WriteLine("Будете выбирать номер четверти самостоятельно? Введите `y` или 'yes' если согласны.");
Console.WriteLine("Если нежелаете , то программа сгенерирует число в диапазоне 1...4.");
string? answer_user = Console.ReadLine();
int num = 0;

// Генерируем рандомное число от 1 до 4.
static int Random_num ()
{
    Random rnd = new Random();
    int num = rnd.Next(1,4);

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
    while (num < 1 || num > 4)
    {
        Console.WriteLine("Введён некорректный номер четверти. Повторите ввод в диапазоне 1...4.");
        num = Enter_num();
    }
} 
else
{
    num = Random_num();
    Console.WriteLine("Сгененрирогвали число: " + num + ".");
}
// Рассчитываем и выводим данные в консоль.
switch (num)
{
    case 1:
    {
        Console.WriteLine("X будет принимать значение больше нуля.");
        Console.WriteLine("Y будет принимать значение больше нуля.");
        break;
    }
    case 2:
    {
        Console.WriteLine("X будет принимать значение меньше нуля.");
        Console.WriteLine("Y будет принимать значение больше нуля.");
        break;
    }
    case 3:
    {
        Console.WriteLine("X будет принимать значение меньше нуля.");
        Console.WriteLine("Y будет принимать значение меньше нуля.");
        break;
    }
    case 4:
    {
        Console.WriteLine("X будет принимать значение больше нуля.");
        Console.WriteLine("Y будет принимать значение меньше нуля.");
        break;
    }    
}