// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowDigits (int n, int m){
    if (n < m) return;
    if (m < n) ShowDigits (n, m+1);
    Console.Write(m + " ");
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
ShowDigits(number, count);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumDigits (int m, int n){
    if (m==n) return n;
    else return m + SumDigits(m + 1, n);
}

Console.WriteLine("Enter first number: ");
int userM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int userN = Convert.ToInt32(Console.ReadLine());
int sum = SumDigits(userM, userN);
Console.Write($"Your sum is {sum}");

// Задача 68*: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

Console.Write("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number N: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = Akkerman(m,n);
Console.WriteLine($"{result}");