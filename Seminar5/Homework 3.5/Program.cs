// Урок 5. Функции и одномерные массивы

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



int [] RandomArray ()
{
    int size = new Random().Next(5, 100);
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++){
        newArray[i] = new Random().Next(100,1000);
    }
    return newArray;
}

void PrintArray(int [] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++){
        Console.Write(arrayPrint[i] + " ");
    }
    Console.WriteLine();
}

void CountOfEvenElem (int [] countArray){
    int count = 0;
    for (int i = 0; i < countArray.Length; i++){
        if(countArray[i] % 2 == 0)
            count ++;
    }
    Console.WriteLine($"-> {count}");
}


int [] randomArray = RandomArray();
PrintArray(randomArray);
CountOfEvenElem(randomArray);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] RandomArray ()
{
    int size = new Random().Next(5, 10);
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++){
        newArray[i] = new Random().Next(1,10);
    }
    return newArray;
}

void PrintArray(int [] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++){
        Console.Write(arrayPrint[i] + " ");
    }
    Console.WriteLine();
}

void SumOfElem (int [] countArray){
    int sum = 0;
    for (int i = 0; i < countArray.Length; i++){
        if(i % 2 != 0)
            sum += countArray[i];
    }
    Console.WriteLine($"-> {sum}");
}

int [] randomArray = RandomArray();
PrintArray(randomArray);
SumOfElem(randomArray);



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double [] RandomArray ()
{
    int size = new Random().Next(5, 10);
    double [] newArray = new double [size];
    for (int i = 0; i < size; i++){
        newArray[i] = Math.Round(new Random().Next(1,100) + new Random().NextDouble(),2);
    }
    return newArray;
}

void PrintArray(double [] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++){
        Console.Write(arrayPrint[i] + " ");
    }
    Console.WriteLine();
}

void MinMaxDif (double [] countArray){
    double minElem = 0;
    double maxElem = 0;
    for (int i = 0; i < countArray.Length; i++){
        if(countArray[i] > maxElem)
            maxElem = countArray[i];
        else
            minElem = countArray[i];
    }
    Console.WriteLine($"-> {maxElem - minElem}");
}


double [] randomArray = RandomArray();
PrintArray(randomArray);
MinMaxDif(randomArray);
