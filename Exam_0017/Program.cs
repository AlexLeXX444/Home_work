// По двум заданным числам проверять является ли одно квадратом другого.

Console.WriteLine("Программа проверяет, является ли одно число квадратом другого.");
Console.WriteLine("Будете вводить чила самостоятельно? Введите `y` или 'yes' если согласны.");
Console.WriteLine("Если нежелаете , то программа сгенерирует числа в диапазоне 1...10000.");
string? answer_user = Console.ReadLine();
int num1 = 0, num2 = 0;

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
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

// Заполняем значения для дальнейших расчётов.
if (answer_user == "y" || answer_user == "yes") 
{
    while (num1 == num2)
    {
        num1 = Enter_num(); 
        num2 = Enter_num();

        if (num1 == num2)
            Console.WriteLine("Числа равны, повторите ввод!");
    }
} 
else
{
    while (num1 == num2)
    {
        num1 = Random_num();
        num2 = Random_num();
    }   

    Console.WriteLine("Сгенерированы числа " + num1 + " и " + num2 + ".");
}

// Рассчитываем и выводим данные в консоль.
if (num1 < num2)
{
    if (Check_two_num(num1, num2) == true)
        Console.WriteLine("Число " + num2 + " является квадратом числа " + num1);
    else 
        Console.WriteLine("Ни одно из представленных чисел не является квадратом другого.");
} else
{
    if (Check_two_num(num2, num1) == true)
        Console.WriteLine("Число " + num1 + " является квадратом числа " + num2);
    else 
        Console.WriteLine("Ни одно из представленных чисел не является квадратом другого.");
}

// Функция проверяет, является ли второе переданное в неё число квадратом второго 
// и возвращает булевое значение.
static bool Check_two_num (int min, int max)
{
    bool ans = false;

    if (max == min * min)
        ans = true;

    return ans;
}