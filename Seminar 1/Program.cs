//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Please input number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Max = 0;
int Min = 0;

if (number1 > number2)
{
    Max = number1;
    Min = number2;
}
else
{
    Max = number2;
    Min = number1;
}

Console.WriteLine($"Max number is " + Max);
Console.WriteLine($"Min number is " + Min);


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Please input number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input numbe3 1: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if(number1 > max) max = number1;
if(number2 > max) max = number2;
if(number3 > max) max = number3;

Console.WriteLine($"Max number is " + max);


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет


Console.WriteLine("Please input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    Console.WriteLine($"Yes, number is even " + number);
}
else
{
    Console.WriteLine($"No, number is odd " + number);
}


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Please input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 1;

while(count <= number)
{
    if(count % 2 == 0)
    {
        Console.Write(count);
    }
    count ++;
}
