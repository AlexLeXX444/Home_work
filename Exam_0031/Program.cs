// Задать массив из 8 элементов и вывести их на экран 

Console.WriteLine("Программа получает на вход массив из 8 элементов и выводит их на экран.");
Console.WriteLine("Будете вводить элементы массива самостоятельно? Введите `y` или 'yes' если согласны.");
Console.WriteLine("Если нежелаете , то программа сгенерирует элементы массив в диапазоне 1...100.");
string? answer_user = Console.ReadLine();
int[] array = new int [8];

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
    int num = Convert.ToInt32(Console.ReadLine());

    return num;
}

// Заполняем значения для дальнейших расчётов.
if (answer_user == "y" || answer_user == "yes")
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Enter_num();
}
else
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Random_num();    
}

// Функция вывода массива в консоль.
void Print_array (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + "  ");
    Console.WriteLine();        
}

// Выполняем рассчет.
Console.WriteLine("Получили массив: ");
Print_array(array);