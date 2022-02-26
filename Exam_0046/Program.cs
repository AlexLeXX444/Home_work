using System;

// Написать программу масштабирования фигуры

// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

Console.WriteLine("Введите координаты в формате (x1,y1) (x2,y2) (x3,y3) (x4,y4) одной строкой.");
Console.WriteLine("Это координаты вершин фигуры.");
String? inputStr = Console.ReadLine();
char[] separators = new char[] { '(',')',',',' ' };
int[]? mainArray = Array.ConvertAll<string, int>(inputStr.Split(separators, StringSplitOptions.RemoveEmptyEntries), int.Parse);

Console.WriteLine("Введите коэффициент смещения.");
double koff = Convert.ToDouble(Console.ReadLine());

// Рассчет смещения координат и перезаполение массива.
double[] CordOffset (double n, int[] entriesMass)
{
    double[] mass = new double[8];
    for (int i=0; i<entriesMass.Length; i++)
        mass[i] = n * entriesMass[i];

    return mass;
}

// Вывод массива в консоль в нужном формате.
void PrinArray (double[] mass)
{
    Console.WriteLine("Получили новые координаты вершин фигуры:");
    Console.WriteLine("(" + mass[0] + "," + mass[1] + ") (" + mass[2] + "," + mass[3] + ") (" + mass[4] + "," + mass[5] + ") (" + mass[6] + "," + mass[7] + ")");
}


PrinArray(CordOffset(koff, mainArray));