/* int [,] CreaterandomTwoDemArray(int a, int b, int min, int max)
{
    int [,] newMatrix = new int [a,b];

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max+1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

int [,] array= CreaterandomTwoDemArray(4,5,1,9); */

//Задача 1. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

/* int [,] CreaterandomTwoDemArray(int a, int b, int min, int max)
{
    int [,] newMatrix = new int [a,b];

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            newMatrix[i,j] = i+j;
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

int [,] array= CreaterandomTwoDemArray(4,5,1,9); */


//Задача 2. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

/* int [,] CreaterandomTwoDimArray(int a, int b, int min, int max)
{
    int [,] newMatrix = new int [a,b];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < b; j++)
            newMatrix[i,j] = new Random().Next(min, max+1);
        
    return newMatrix;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int [,] UpdateTwoDimArrayEvenIndexSquare(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            array [i,j] *= array[i,j];
        }
    }

    return array;
}

int [,] array = CreaterandomTwoDimArray(4,5,1,9);

PrintArray(array);

Console.WriteLine();

array = UpdateTwoDimArrayEvenIndexSquare(array);

PrintArray(array); */

// Задача 3. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int [,] CreaterandomQuadArray(int a, int min, int max)
{
    int [,] newMatrix = new int [a,a];

    for (int i = 0; i < a; i++)
        for (int j = 0; j < a; j++)
            newMatrix[i,j] = new Random().Next(min, max+1);
        
    return newMatrix;
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int GetSumOnMainDiag(int [,] array)
{
    int sum = 0;
     for (int i = 0; i < array.GetLength(0); i++)
     {
        sum+=array[i,i];
     }
     return sum;
}

int [,] array = CreaterandomQuadArray(5,1,9);

PrintArray(array);

Console.WriteLine();

Console.WriteLine(GetSumOnMainDiag(array));