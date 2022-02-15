// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

Console.WriteLine("Программа получает на вход массив из 8 элементов и заполняет рандомно нулями и единицами.");
int[] array = new int [8];

// Генерируем рандомное число от 0 до 1.
int Random_num ()
{
    Random rnd = new Random();
    int num = rnd.Next(0,2);

    return num;
}

// Функция вывода массива в консоль.
void Print_array (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + "  ");
    Console.WriteLine();        
}

// Заполняем значения.
for (int i = 0; i < array.Length; i++)
    array[i] = Random_num();    

// Выполняем рассчет.
Console.WriteLine("Получили массив: ");
Print_array(array);