// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y.

Console.WriteLine("Программа проверяет истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y.");
bool x, y;
int count = 0;

// Рассчет функции от полученных значений.
bool Function_resolve (bool x_input, bool y_input) 
{
    bool answer = false;
    if (!(x_input && y_input) == !x_input || !y_input)
        answer = true;

    return answer;
}

// Для конвертирования булевоегого значения в цифровое.
// Используется для более понятного вывода.
int Function_convert (bool input_boolean)
{
    int a = 0;

    if (input_boolean)
        a = 1;

    return a;
}

x = false;
y = false;
Console.WriteLine("При Х = " + Function_convert(x) + " и при Y = " + Function_convert(y) + " функция возвращает значение: " + Function_resolve(x, y));
if (Function_resolve(x, y) == true) count++;

x = false;
y = true;
Console.WriteLine("При Х = " + Function_convert(x) + " и при Y = " + Function_convert(y) + " функция возвращает значение: " + Function_resolve(x, y));
if (Function_resolve(x, y) == true) count++;

x = true;
y = false;
Console.WriteLine("При Х = " + Function_convert(x) + " и при Y = " + Function_convert(y) + " функция возвращает значение: " + Function_resolve(x, y));
if (Function_resolve(x, y) == true) count++;

x = true;
y = true;
Console.WriteLine("При Х = " + Function_convert(x) + " и при Y = " + Function_convert(y) + " функция возвращает значение: " + Function_resolve(x, y));
if (Function_resolve(x, y) == true) count++;

if (count == 4)
    Console.WriteLine("Функция истинна.");
else 
    Console.WriteLine("Функция ложна.");