// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int IntegersSum(int m, int n)
{
    if (m == n)
        return m;
    if (m > n)
    {
        int temp = m;
        m = n;
        n = temp;
    }
    if (m < n)
        {
            return m + IntegersSum(m + 1, n);
        }
    return 0;
}

Console.WriteLine("Programm to show all integers from M to N");

Console.Write("Input integer N:\t");

int n;

while (!int.TryParse(Console.ReadLine()!, out n) || n <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.Write("Input integer N:\t");
}

Console.Write("Input integer M:\t");

int m;

while (!int.TryParse(Console.ReadLine()!, out m) || m <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.Write("Input integer M:\t");
}

IntegersSum(n, m);

Console.WriteLine($"Numbers sum from {m} to {n} is {IntegersSum(m, n)}");