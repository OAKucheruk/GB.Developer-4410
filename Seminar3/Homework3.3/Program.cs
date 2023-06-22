//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да



void IsPalindr(int num){
    int leftNum = num / 1000;
    int leftNum1 = leftNum / 10; 
    int leftNum2 = leftNum % 10;
    int rightNum = num % 100;
    int rightNum1 = rightNum % 10;
    int rightNum2 = rightNum / 10;
    if (leftNum1 == rightNum1 && leftNum2 == rightNum2){
        Console.WriteLine($"Number {num} Is Palindrom");
    }  
    else
    {
        Console.WriteLine($"Number {num} Is NOT Palindrom");
    }
}

Console.Write("Please input 5-digit number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if(userNumber < 9999 || userNumber > 99999){
    Console.WriteLine("You entered NOT 5-digit number");
}
else{
    IsPalindr(userNumber);
}


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double LongLineAB(int xA, int xB, int yA, int yB, int zA, int zB){
    double longLine = Math.Sqrt((xB - xA)*(xB - xA) + (yB - yA)*(yB - yA)+(zB - zA)*(zB - zA));
    longLine = Math.Round(longLine, 2);
    return longLine;
}

Console.WriteLine("Please input x of A: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input y of A: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input z of A: ");
int zCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input x of B: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input y of B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input z of B: ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double dist = LongLineAB(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);

Console.WriteLine($"Distance is: {dist}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void NumCube(int N){
    int current = 1;
    while(current <= N){
        double res = Math.Pow(current, 3);
        Console.Write($"{res:f0}, ");
        current ++;
    }
    Console.WriteLine("\b\b.");
}

Console.Write("Please input number: ");
int number = Convert.ToInt32(Console.ReadLine());

NumCube(number);