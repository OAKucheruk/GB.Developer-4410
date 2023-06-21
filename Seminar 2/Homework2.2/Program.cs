// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

/*
Console.WriteLine("Please input 3-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int sec = (num / 10) % 10;
Console.WriteLine($"Result is {sec}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

/*

Console.WriteLine("Please input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int GetThirdNum(int number){
    while(number > 999){
        number = number / 10;
    } 
    return number % 10;
}

bool CheckNum(int number){
    if(number < 100){
        Console.WriteLine("There is no third digit");
        return false;
    }
    return true;

}

if(CheckNum(num)){
    Console.WriteLine(GetThirdNum(num));
}

*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Please input weekday number 1-7 : ");
int num = Convert.ToInt32(Console.ReadLine());

bool IsWorkday(int weekDay){
    if(weekDay <= 5){
        return true;
    }
    else{
        return false;
    }
}

bool CheckWeekday(int number){
    if(number > 1 && number < 7){
        return true;
    }
    else{
        Console.WriteLine("It is not a weekday number, please input weekday number 1-7");
        return false;
    }
}

if(CheckWeekday(num)){
    if(IsWorkday(num)){
        Console.WriteLine("It is working day");
    }
    else{
        Console.WriteLine("It is weekend");
    }
    
}

