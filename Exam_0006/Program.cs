// Выяснить является ли число чётным

Console.WriteLine("Будете вводить чило самостоятельно? Введите `y` или 'yes' если согласны.");
Console.WriteLine("Если нежелаете , то программа сгенерирует число в диапазоне 1...1000.");
string? answer_user = Console.ReadLine();
int num;

// Генерируем рандомное число от 1 до 1000.
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
    num = Enter_num(); 
} else
{
    num = Random_num();
    Console.WriteLine("Сгенерировано число: " + num + ".");
}

// Рассчитываем какое число больше и выводим ответ.
if (num % 2 == 0)
    Console.WriteLine(num + " - число чётное.");
else 
    Console.WriteLine(num + " - число НЕ чётное.");  