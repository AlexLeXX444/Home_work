// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Программы рассчитывает расстояние между двумя точками в пространстве.");
Console.WriteLine("1 - будем рассчитывать в 2D.");
Console.WriteLine("2 - будем рассчитывать в 3D.");
Console.WriteLine("Выберите вариант рассчета.");
int user_answer_metod = Convert.ToInt32(Console.ReadLine());

// Проверяем выбор пользователя. Пока не выберет нормально, будем спрашивать.
while (user_answer_metod < 1 || user_answer_metod > 2)
{
    Console.WriteLine("Некорректный ввод, повторте.");
    user_answer_metod = Convert.ToInt32(Console.ReadLine());
}

// Функция рассчета расстояние между двумя точками в 2D пространстве.

// Функция рассчета расстояние между двумя точками в 3D пространстве.

// Генерируем рандомное число от 1 до 1000.
int Random_num ()
{
    Random rnd = new Random();
    int num = rnd.Next(1,1000);

    return num;
}

// Считываем ввод пользователя.
static int Enter_num ()
{
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}