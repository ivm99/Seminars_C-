// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

/* double [,] CreateTwoDimArrayDouble(int a, int b, int min, int max)
{
    double [,] newArray = new double [a,b];
    
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            newArray [i,j] = Math.Round(new Random().NextDouble()*(max-min)+min,2);
        }
    }

    return newArray;
}

void PrintArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите min число: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите max число: ");
int max = Convert.ToInt32(Console.ReadLine());

double [,] myArray = CreateTwoDimArrayDouble(rows, columns, min, max);

PrintArray(myArray); */


//__________________________________________________________________________________________________________________________________________________________________

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такого числа в массиве нет

/* int [,] CreateRandomTwoDimArray(int a, int b, int min, int max)
{
    int [,] newMatrix = new int [a,b];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            newMatrix[i,j] = new Random().Next(min, max+1);
     
    return newMatrix;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int FindArrayElementByIndex(int [,] array, int a, int b)
{
    if (array.GetLength(0)>a && array.GetLength(1)>b) 
    {
        int result = array [a,b];
        Console.WriteLine($"Значение элемента с индексом ({a},{b}): {result}");
        return result;
    }
    else 
    {
        Console.WriteLine("В массиве нет такого элемента!");
        return -1;
    }
    
    
}


Console.Write("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите min число: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите max число: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandomTwoDimArray(rows, columns, min, max);
Console.WriteLine();
Console.WriteLine("Сгенерированный массив:");
PrintArray(myArray);

Console.Write("Введите индекс элемента массива (через запятую): ");
string elementIndex = Console.ReadLine();

string [] elementIndexArray = elementIndex.Split(',');

int rowIndex = Int32.Parse(elementIndexArray[0]);
int columnIndex = Int32.Parse(elementIndexArray[1]);

FindArrayElementByIndex(myArray, rowIndex, columnIndex); */


//__________________________________________________________________________________________________________________________________________________________________

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRandomTwoDimArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a, b];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            newMatrix[i, j] = new Random().Next(min, max + 1);

    return newMatrix;
}

double[] GetColumnsArithmeticMean(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    double [] newArray = new double[columns];

    for (int j = 0; j < columns; j++)
    {
        double arithmeticMean = 0;
        
        for (int i = 0; i < rows; i++)
        {
            
            arithmeticMean += array [i,j];
        }
        newArray [j] = Math.Round(arithmeticMean / rows,2);
    }

    return newArray;
}

void PrintTwoDimArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");
       
}

Console.Write("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите min число: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите max число: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandomTwoDimArray(rows, columns, min, max);
Console.WriteLine();
Console.WriteLine("Сгенерированный массив:");

PrintTwoDimArray(myArray);

double [] myArray2 = GetColumnsArithmeticMean(myArray);

Console.Write("Среднее арифметическое каждого столбца: ");

PrintArray(myArray2);