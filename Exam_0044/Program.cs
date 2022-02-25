// Найти точку пересечения двух прямых заданных уравнением 
// y1 = k1 * x + b1, y2 = k2 * x + b2, 
// b1 k1 и b2 и k2 заданы.

Console.WriteLine("Введите угловой коэффициэнт первой прямой (к1).");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку первой прямой (b1).");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите угловой коэффициэнт второй прямой (к2).");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку второй прямой (b2).");
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1 != k2)
{
    double x = (b2 - b1) / (k1 - k2);
    Console.WriteLine("Точка пересечения прямых расположена в координатах:");
    Console.WriteLine("Х ::: " + x);
    Console.WriteLine("Y ::: " + (k1 * x + b1));
} else
    Console.WriteLine("Прямые параллельны.");