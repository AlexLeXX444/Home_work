// Определить сколько чисел больше 0 введено с клавиатуры

// Задаём массив чисел и элемент, обозначающий количество чисел в будущем массиве.
int elements = 0;
int[] massive = new int [UserEnterNumElements(elements)];
int counterPlusNum = 0;

// Метод будет просить пользователя ввести положительное число.
// Пока не будет положительного числа - не остановится.
int UserEnterNumElements (int num)
{
    Console.WriteLine("Введите положительное число. Это будет количество дальнейших чисел для проверки.");
    num = Convert.ToInt32(Console.ReadLine());

    while (!GetElement(num))
    {
        Console.WriteLine("Число должно быть положительное. Повторите ввод.");
        num = Convert.ToInt32(Console.ReadLine());
    }

    return num;
}

// Заполнение массива вводом пользователя.
int[] UserEnterNums (int[] mass)
{
    for (int i=0; i<mass.Length; i++)
    {
        Console.WriteLine("Введите " + (i+1) + " число:");
        mass[i] = Convert.ToInt32(Console.ReadLine());
    }

    return mass;
}

// Проверка числа на то, положительное оно или нет.
bool GetElement (int n)
{
    if (n > 0)
        return true;
    else 
        return false;
}

// Проверка условиям зачачи и вывод ответа.
UserEnterNums(massive);

for (int i=0; i<massive.Length; i++)
{
    if (GetElement(massive[i]))
        counterPlusNum++;
}

if (GetElement(counterPlusNum))
    Console.WriteLine("Число элементов больше нуля: " + counterPlusNum);
else
    Console.WriteLine("Нет элементов больше нуля");