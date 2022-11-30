// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintIntegers(int n)
{
    if (n == 1)
        Console.Write($"{n}");
    else
    {
        Console.Write($"{n}, ");
        PrintIntegers(n - 1);
    }
}

Console.WriteLine("Programm to show all integers from N to 1");

Console.Write("Input N:\t");

int n;

while (!int.TryParse(Console.ReadLine()!, out n) || n < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Wrong input");
    Console.ResetColor();
    Console.Write("Input N:\t");
}

PrintIntegers(n);