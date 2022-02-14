// Показать таблицу квадратов чисел от 1 до N.

Console.WriteLine("Программы выводит таблицу квадратов чисел от 1 до N.");
Console.WriteLine("Будете вводить чило N самостоятельно? Введите `y` или 'yes' если согласны.");
Console.WriteLine("Если нежелаете, то программа сгенерирует число в диапазоне 1...100.");
string? answer_user = Console.ReadLine();
int num;

// Генерируем рандомное число от 1 до 100.
int Random_num ()
{
    Random rnd = new Random();
    int num = rnd.Next(1,100);

    return num;
}

// Считываем ввод пользователя.
int Enter_num ()
{
    Console.WriteLine("Введите число:");
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

if (answer_user == "y" || answer_user == "yes")
    num = Enter_num();
else
    num = Random_num();

for (int i = 1; i <= num; i++)
    Console.WriteLine("Квадрат числа " + i + " равен: " + (i*i));