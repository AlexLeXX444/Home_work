// Показать четные числа от 1 до N

Console.WriteLine("Программы четные выводит числа от 1 до N.");
Console.WriteLine("Будете вводить чило N самостоятельно? Введите `y` или 'yes' если согласны.");
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

// Рассчитываем и выводим данные в консоль.
if (num >= 2)
{
    for (int i = 2; i <=num; i = i + 2)
    {
        if (i % 2 == 0)
            Console.Write(i + "  ");
    }
} else
    Console.WriteLine("Нечего выводить!");