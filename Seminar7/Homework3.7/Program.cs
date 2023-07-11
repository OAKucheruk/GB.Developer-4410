// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



double [,] Create2DArray ()
{
    Console.WriteLine("Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of columns: ");
    int userColumns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter min possible value: ");
    int userMin = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter max possible value: ");
    int userMax = Convert.ToInt32(Console.ReadLine());

    double [,] created2DArray = new double [userRows,userColumns];

    for (int i = 0; i < userRows; i++){
        for (int j = 0; j < userColumns; j++){
            created2DArray[i,j] = Math.Round((new Random().Next(userMin, userMax + 1) + new Random().NextDouble()), 2);
        }
    }
    return created2DArray;
}

void Print2DArray(double [,] array2D){
    for (int i = 0; i < array2D.GetLength(0); i++){
        for (int j = 0; j < array2D.GetLength(1); j++){
            Console.Write(array2D[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double [,] newArray = Create2DArray();
Print2DArray(newArray);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Fill2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100)/10;
            }   
        }
}


void Print2DArray(int [,] array2D){
    for (int i = 0; i < array2D.GetLength(0); i++){
        for (int j = 0; j < array2D.GetLength(1); j++){
            Console.Write(array2D[i,j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
}

Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [5,5];
Fill2DArray(numbers);
Print2DArray(numbers);

void CheckArray (int [,] array){
    if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
    {
        Console.WriteLine("There is no such element in the array");
    }
    else
    {
    Console.WriteLine($"Element value of {n} row and {m} column is {numbers[n-1,m-1]}");
    }
}

CheckArray(numbers);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Fill2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void Print2DArray(int [,] array2D){
    for (int i = 0; i < array2D.GetLength(0); i++){
        for (int j = 0; j < array2D.GetLength(1); j++){
            Console.Write(array2D[i,j] + " ");
        }
        Console.WriteLine(); 
    }
    Console.WriteLine(); 
}

Console.WriteLine("введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());

int[,] userArray = new int[n, m];
Fill2DArray(userArray);
Print2DArray(userArray);

void AvgColArray(int [,] array)
{
    for (int j = 0; j < userArray.GetLength(1); j++)
    {
        double avarage = 0;
        for (int i = 0; i < userArray.GetLength(0); i++)
        {
            avarage = (avarage + userArray[i, j]);
        }
        avarage = Math.Round((avarage / n), 2);
        Console.Write(avarage + "; ");
    }
    Console.WriteLine();
}

AvgColArray(userArray);





