// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("Программы выводит наибольшую цифру числа в диапазоне 10...99");
Console.WriteLine("Будете вводить чило самостоятельно? Введите `y` или 'yes' если согласны.");
Console.WriteLine("Если нежелаете , то программа сгенерирует число в диапазоне 10...99.");
string? answer_user = Console.ReadLine();
int num;

// Генерируем рандомное число от 10 до 99.
static int Random_num ()
{
    Random rnd = new Random();
    int num = rnd.Next(10,99);

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
int answer = num % 10,
    i = num;

if (num > 9 && num < 100)
{
    while (i > 0)
    {
        if (answer < (i % 10))
            answer = i % 10;

        i = i / 10;
    }

    Console.WriteLine("Наибольшая цифра числа " + num + " будет: " + answer);
}    
else
    Console.WriteLine("Число НЕ входит в заданный диапазон.");