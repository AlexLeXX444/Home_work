// Возведите число А в натуральную степень B используя цикл

Console.WriteLine("Программа возводит число А в степень В.");
Console.WriteLine("Будете вводить чило А и степень В самостоятельно? Введите `y` или 'yes' если согласны.");
Console.WriteLine("Если нежелаете, то программа сгенерирует числа в диапазоне -20...20.");
string? answer_user = Console.ReadLine();
int num, stepen;

// Генерируем рандомное число от -20 до 20.
int Random_num ()
{
    Random rnd = new Random();
    int num = rnd.Next(-20,20);

    return num;
}

// Считываем ввод пользователя.
int Enter_num ()
{
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

// Сверяем ввод пользователя и присваем значения.
if (answer_user == "y" || answer_user == "yes")
{
    Console.WriteLine("Введите число.");
    num = Enter_num();
    Console.WriteLine("Введите степень в которую нужно возвести.");
    stepen = Enter_num();
}
else
{
    num = Random_num();
    stepen = Random_num();
    Console.WriteLine("Сгенерировали число " + num + " и будем возводить его в " + stepen + " степень.");
}

// Возводим число в положительную степень.
int Increase_stepen_plus (int n, int st)
{
    int num = n;
    for (int i = 0; i < st - 1; i++)
        n = n * num;
    return n;
}

// Возводим число в отрицательную степень.
double Increase_stepen_minus (int n, int st)
{
    double count;
    st = st * (-1);
    int num = n;
    for (int i = 0; i < st - 1; i++)
        n = n * num;

    count =  1.0 / n;
    return count;
}

if (num == 0 && stepen == 0)
    Console.WriteLine("Число и степень НЕ должны одновременно равняться нулю. Так НЕЛЬЗЯ !!!");
else
{
    if (num == 0 || stepen == 0)
    {
        if (num == 0)
            Console.WriteLine("Ноль в любой степени равен нулю.");
        else
            Console.WriteLine("Любое число в нулевой степени равно единице. Кроме нуля в нулевой степени. Так НЕЛЬЗЯ !!!");
    } else
    {
        if (stepen > 0)
            Console.WriteLine("Число " + num + " в степени " + stepen + " равно: " + Increase_stepen_plus(num, stepen));
        else
            Console.WriteLine("Число " + num + " в степени " + stepen + " равно: " + Increase_stepen_minus(num, stepen));
    }
}