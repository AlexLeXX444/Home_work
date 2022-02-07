// Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("Программа проверяет, кратно ли число 7 и 23.");
Console.WriteLine("Будете вводить чило самостоятельно? Введите `y` или 'yes' если согласны.");
Console.WriteLine("Если нежелаете , то программа сгенерирует число в диапазоне 1...10000.");
string? answer_user = Console.ReadLine();
int num;

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
    Console.WriteLine("Введите число:");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

// Заполняем значения для дальнейших расчётов.
if (answer_user == "y" || answer_user == "yes") 
    num = Enter_num(); 
else
    num = Random_num();

// Рассчитываем и выводим данные в консоль.
if ((num%7) == 0 && (num%23) == 0 )
    Console.Write("Число " + num + " кратно 7 и 23.");
else
    Console.Write("Число " + num + " НЕ кратно 7 и 23.");