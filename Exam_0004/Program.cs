// Найти максимальное из трех чисел

Console.WriteLine("Будете вводить чила самостоятельно? Введите `y` или 'yes' если согласны.");
Console.WriteLine("Если нежелаете вводить самостоятельно, то программа сгенерирует три числа в диапазоне 1...1000.");
string? answer_user = Console.ReadLine();
int num1, num2, num3;

// Генерируем рандомные числа от 1 до 1000.
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
    num1 = Enter_num();
    num2 = Enter_num();
    num3 = Enter_num();    
} else
{
    num1 = Random_num();
    num2 = Random_num();
    num3 = Random_num();
    Console.WriteLine("Сгенерированы три числа: " + num1 + " , " + num2 + " , " + num3);
}

// Рассчитываем какое число больше и выводим ответ.
if (num1 >= num2 && num1 >= num3)
{
    Console.WriteLine("Самое большое из трёх представленных: " + num1);
} else 
{
    if (num2 >= num3)
        Console.WriteLine("Самое большое из трёх представленных: " + num2);
    else
        Console.WriteLine("Самое большое из трёх представленных: " + num3);    
}