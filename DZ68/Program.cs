// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AckermannFunction (int m, int n)
{
    if (m == 0)
        return (n + 1);
    if (m > 0 && n == 0)
        return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0)
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    return AckermannFunction(m, n);
}

Console.WriteLine("Programm to calculate integers under Ackerman function");

Console.Write("Input integer N:\t");

int n;

while (!int.TryParse(Console.ReadLine()!, out n) || n < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.Write("Input integer N:\t");
}

Console.Write("Input integer M:\t");

int m;

while (!int.TryParse(Console.ReadLine()!, out m) || m < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.Write("Input integer M:\t");
}

Console.WriteLine(AckermannFunction(m, n));