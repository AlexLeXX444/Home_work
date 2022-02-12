// Программа проверяет пятизначное число на палиндромом.

Console.WriteLine("Программа проверяет пятизначное число на палиндромом.");
Console.WriteLine("Будете вводить пятизначное чило самостоятельно? Введите `y` или 'yes' если согласны.");
Console.WriteLine("Если нежелаете , то программа сгенерирует число в диапазоне 10000...99999.");
string? answer_user = Console.ReadLine();
int num;

// Генерируем рандомное число от 10000 до 99999.
static int Random_num ()
{
    Random rnd = new Random();
    int num = rnd.Next(10000,99999);

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
    while (num < 10000 || num > 99999)
    {
        Console.WriteLine("Число не пятизначное, повторите ввод.");
        num = Enter_num();
    }
} 
else
{
    num = Random_num();
    Console.WriteLine("Сгенерировали число: " + num + ".");
}

// Рассчитываем и выводим данные в консоль.
String str_num = Convert.ToString(num);
int count = 0;
int j = str_num.Length;
for (int i = 0; i < (str_num.Length / 2); i++)
{
    if (str_num[i] == str_num[j-1])
        count++;
    j--;
}

if (count == (str_num.Length / 2))
    Console.WriteLine("Число является палиндромом.");
else 
    Console.WriteLine("Число НЕ является палиндромом.");