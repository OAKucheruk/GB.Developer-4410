// Урок 8. Двумерные массивы. Продолжение

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
3/
int [,] Created2DArray (int rows, int columns, int minV, int maxV)
{
    int [,] createdArray = new int [rows,columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            createdArray[i,j] = new Random().Next(minV, maxV + 1);
    return createdArray;
}

void ShowArray (int [,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Write("Input count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int userMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int userMax = Convert.ToInt32(Console.ReadLine());

int [,] newArray = Created2DArray(userRows,userColumns,userMin,userMax);
ShowArray(newArray);



void SortDecOrder(int [,] arrayToSort)
{
    int [,] sortedArr = new int[arrayToSort.GetLength(0), arrayToSort.GetLength(1)];
    for (int i = 0; i < arrayToSort.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToSort.GetLength(1); j++)
        {
            for (int k = 0; k < arrayToSort.GetLength(1) - 1; k++)
            {
                if (arrayToSort[i, k] < arrayToSort[i, k + 1])
                {
                    int temp = arrayToSort[i, k + 1];
                    arrayToSort[i, k + 1] = arrayToSort[i, k];
                    arrayToSort[i, k] = temp;
                }
            }
        }
    }
}

SortDecOrder(newArray);
ShowArray(newArray);



// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int [,] Created2DArray (int rows, int columns, int minV, int maxV)
{
    int [,] createdArray = new int [rows,columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            createdArray[i,j] = new Random().Next(minV, maxV + 1);
    return createdArray;
}

void ShowArray (int [,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}


void MinSumOfElem(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1} строка");
}

Console.Write("Input count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value: ");
int userMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value: ");
int userMax = Convert.ToInt32(Console.ReadLine());

int [,] newArray = Created2DArray(userRows,userColumns,userMin,userMax);
ShowArray(newArray);
MinSumOfElem(newArray);



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



int [,] CreateArray (int rows, int columns)
{
    int [,] createdArray = new int [rows,columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            createdArray[i,j] = new Random().Next(1, 10);
    return createdArray;
}

void ShowArray (int [,] array){
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] MatrixMultyply (int [,] array1, int [,] array2)
{
    int [,] result = new int[array1.GetLength(0),array2.GetLength(1)];

    int sum = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum += (array1[i,k] * array2[k,j]);
            }
            result[i,j] = sum;
            
        }
    }
    return result;
}

Console.Write("Input count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input count of columns: ");
int userColumns = Convert.ToInt32(Console.ReadLine());
int[,] firstArray = CreateArray(userRows, userColumns);
ShowArray(firstArray);
int[,] secondArray = CreateArray(userRows, userColumns);
ShowArray(secondArray);
int[,] resultArray = MatrixMultyply(firstArray,secondArray);
ShowArray(resultArray);



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



void FillArray(int[,,] arrToFill)
{
    int count = 10;
    for (int i = 0; i < arrToFill.GetLength(0); i++)
    {
        for (int j = 0; j < arrToFill.GetLength(1); j++)
        {
            for (int k = 0; k < arrToFill.GetLength(2); k++)
            {
                arrToFill[k, i, j] += count;
                count += 3;
            }
        }
    }
}

void PrintIndex(int[,,] arrToPrint)
{
    for (int i = 0; i < arrToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrToPrint.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < arrToPrint.GetLength(2); k++)
            {
                Console.Write($"{arrToPrint[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintIndex(array3D);



// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int [,]SpiralArray (int rows, int cols)
{
    int [,] resArray = new int [rows,cols];
    int count = 1;
    int startRow = 0;
    int startCol = 0;
    int endRow = resArray.GetLength(0) - 1;
    int endCol = resArray.GetLength(1) - 1;
    while (count < rows * cols)
    {
        for (int i = startRow; i <= endRow; i++){
            resArray[startRow,i] = count;
            count++;
        }
        startCol++;

        for (int i = startCol; i <= endCol; i++){
            resArray[i, endRow] = count;
            count++;
        }
        endRow--;

        if (startCol <= endCol){
            for (int i = endRow; i >= startRow; i--){
                resArray[endCol,i] = count;
                count++;
            }
            endCol--;
        }
        if (startRow <= endRow){
            for (int i = endCol; i >= startCol; i--){
                resArray[i,startRow] = count;
                count++;
            }
            startRow++;
        }

    }
    return resArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

PrintArray(SpiralArray(4,4));