// Показать числа от -N до N

Console.WriteLine("Программы выводит числа от -N до N.");
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
for (int i = (num * (-1)); i <=num; i++)
    Console.Write(i + "  ");