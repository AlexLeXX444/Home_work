// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Программы выводит первую и последнюю цифру трехзначного числа, убирая при этом среднюю.");
Console.WriteLine("Будете вводить чило самостоятельно? Введите `y` или 'yes' если согласны.");
Console.WriteLine("Если нежелаете , то программа сгенерирует число в диапазоне 100...999.");
string? answer_user = Console.ReadLine();
int num;

// Генерируем рандомное число от 100 до 999.
static int Random_num ()
{
    Random rnd = new Random();
    int num = rnd.Next(100,999);

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
if (num > 99 && num < 1000)
    Console.WriteLine("Дано число на входе " + num + ". Убрав среднюю цифру получим " + (num / 10 / 10) + (num % 10));
else
    Console.WriteLine("Число НЕ трехзначное");