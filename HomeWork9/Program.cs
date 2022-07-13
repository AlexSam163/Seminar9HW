/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int number1 = Input("Введите значение N: ");
int number2 = 1;

Console.WriteLine(OutputFunction(number1, number2));

int OutputFunction(int a, int b)
{
    if (b == a)
    {
        return b;
    }
    Console.Write(OutputFunction(a, b + 1) + ", ");
    return b;
}

int Input(string numberName)
{
    Console.Write(numberName);
    return Convert.ToInt32(Console.ReadLine());
}



/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int number1 = Input("Введите  значение M: ");
int number2 = Input("Введите  значение N: ");

int result = ResultOfSum(number1, number2);
Console.WriteLine("Сумма натуральных элементов : " + result);

int ResultOfSum(int a, int b)
{
    if(a > b)
    {
        return a + ResultOfSum(a - 1, b);
    }
    else if (a < b)
    {
        return b + ResultOfSum(a, b - 1);
    }
    else
    {
        return a;
    }
}

int Input(string numberName)
{
    Console.Write(numberName);
    return Convert.ToInt32(Console.ReadLine());
}


/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9  */

int m = Input("m");
int n = Input("n");

int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return Ackermann(m - 1, 1);
    else if (m > 0 && n > 0)
        return Ackermann(m - 1, Ackermann(m, n - 1));
    return Ackermann(m, n);
}

if (m >= 0 && n >= 0)
{
    Console.WriteLine($"Результат: {Ackermann(m, n)}");
}
else
{
    Console.WriteLine("Функция не рабочая");
}

int Input(string numberName)
{
    Console.Write($"Введите значение для {numberName}: ");
    return Convert.ToInt32(Console.ReadLine());
}