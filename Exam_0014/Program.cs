// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Программы выводит третью цифру числа или предупредит если таковой нет.");
Console.WriteLine("Будете вводить чило самостоятельно? Введите `y` или 'yes' если согласны.");
Console.WriteLine("Если нежелаете , то программа сгенерирует число в диапазоне 1...10000.");
string? answer_user = Console.ReadLine();
int num, answer = 0;

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

if (num > 99)
{
    Console.Write("Третья цифра числа " + num);
    while (num > 99)
    {
        answer = num % 10;
        num = num / 10;
    }
    Console.Write(" будет " + answer + ".");
}
else
    Console.Write("Число " + num + " не имеет третьей цифры.");