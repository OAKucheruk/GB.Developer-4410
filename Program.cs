// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int NatPower (int numA, int numB)
{
    int power = 1;
    for (int i = 0; i < numB; i++){
        power *= numA;
    }
    return power;
}

Console.WriteLine("Please input number A: ");
int userNumA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please input number B: ");
int userNumB = Convert.ToInt32(Console.ReadLine());


int PowRes = NatPower(userNumA, userNumB);
Console.WriteLine($"Result is: {PowRes}");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int CountDigSum(int num){
    int sum = 0;
    for (int count = 0; num > 0; count++){
        sum += num % 10;
        num /= 10;      
    }
    return sum;
}

Console.WriteLine("Please input number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int count_res;

if (userNum >= 0)
    count_res = CountDigSum(userNum);
else{
    int userNum1 = (-1) * userNum;
    count_res = CountDigSum(userNum1);
}

Console.WriteLine(count_res);



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] CreateNewArray(int size_array){
    int [] randomArray1 = new int [size_array];
    for (int i = 0; i < size_array; i++){
        randomArray1[i] = new Random().Next(0,99);
    }
    return randomArray1;
}

void PrintArray(int [] arrayToPrint){
    Console.WriteLine("Your array is ");
    for (int i = 0; i < arrayToPrint.Length; i++){
        Console.Write(arrayToPrint[i]+" ");
    }
}

int size = 8;

int [] newArray = CreateNewArray(size);
PrintArray(newArray);