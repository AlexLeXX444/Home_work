// Найти сумму чисел от 1 до А

Console.WriteLine("Программы находит сумму чисел от 1 до А.");
Console.WriteLine("Будете вводить чило А самостоятельно? Введите `y` или 'yes' если согласны.");
Console.WriteLine("Если нежелаете, то программа сгенерирует число в диапазоне 1...100.");
string? answer_user = Console.ReadLine();
int num, count = 0;

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

// Сверяем ввод пользователя и присваем значение числу А (в нашей программе переменная num).
if (answer_user == "y" || answer_user == "yes")
    num = Enter_num();
else
    num = Random_num();

for (int i = 1; i <= num; i++)
    count = count + i;

Console.WriteLine("Сумма чисел составила: " + count);