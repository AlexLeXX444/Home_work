// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Программы рассчитывает расстояние между двумя точками в пространстве.");
Console.WriteLine("1 - будем рассчитывать в 2D.");
Console.WriteLine("2 - будем рассчитывать в 3D.");
Console.WriteLine("Выберите вариант рассчета.");
String? user_answer_metod = Console.ReadLine();

// Проверяем выбор пользователя. Пока не выберет нормально, будем спрашивать.
while (Convert.ToInt32(user_answer_metod) < 1 || Convert.ToInt32(user_answer_metod) > 2)
{
    Console.WriteLine("Некорректный ввод, повторте.");
    user_answer_metod = Console.ReadLine();
}

Console.WriteLine("Будете вводить координаты точек автоматически? Введите y или yes если согласны.");
Console.WriteLine("Если не согласны, то программа сгенерирует координаты автоматически в диапазоне -100 ...100.");
String? user_anwer_introduct = Console.ReadLine();

// Функция рассчета расстояние между двумя точками в 2D пространстве.
double Dot_distance_2D (int[] dot1, int[] dot2)
{
    double distance;
    distance = Math.Sqrt(Math.Pow(dot2[0] - dot1[0], 2) + Math.Pow(dot2[1] - dot1[1], 2));

    return distance;
}

// Функция рассчета расстояние между двумя точками в 3D пространстве.
double Dot_distance_3D (int[] dot1, int[] dot2)
{
    double distance;
    distance = Math.Sqrt(Math.Pow(dot2[0] - dot1[0], 2) + Math.Pow(dot2[1] - dot1[1], 2) + Math.Pow(dot2[2] - dot1[2], 2));

    return distance;
}

// Заполняем массив рандомными числами.
int[] Random_num_array (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100,100);
    return array;
}

// Вывод массива в консоль.
void Print_array (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
    Console.WriteLine();
}

int[] dot1_coord = new int [Convert.ToInt32(user_answer_metod) + 1];
int[] dot2_coord = new int [Convert.ToInt32(user_answer_metod) + 1];

// Заполняем данные по координатам точек.
if (user_anwer_introduct == "y" || user_anwer_introduct == "yes")
{
    for (int i = 0; i < dot1_coord.Length; i++)
    {
        Console.WriteLine("Введите " + (i+1) + " координату первой точки");
        dot1_coord[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < dot2_coord.Length; i++)
    {
        Console.WriteLine("Введите " + (i+1) + " координату второй точки");
        dot1_coord[i] = Convert.ToInt32(Console.ReadLine());
    }
} 
else
{
    Random_num_array(dot1_coord);
    Console.WriteLine("Сгенерировали координаты первой точки.");
    if (user_answer_metod == "1")
        Console.WriteLine("X  ,  Y");
    else 
        Console.WriteLine("X  ,  Y ,  Z");
    Print_array(dot1_coord);

    Random_num_array(dot2_coord);
    Console.WriteLine("Сгенерировали координаты второй точки.");
    if (user_answer_metod == "1")
        Console.WriteLine("X  ,  Y");
    else 
        Console.WriteLine("X  ,  Y  ,  Z");
    Print_array(dot2_coord);
}

if (Convert.ToInt32(user_answer_metod) == 1)   
    Console.WriteLine("Расстояние между двумя точками в 2D: " + Dot_distance_2D(dot1_coord,dot2_coord));
else
    Console.WriteLine("Расстояние между двумя точками в 3D: " + Dot_distance_3D(dot1_coord,dot2_coord));