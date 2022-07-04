//Задача 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

/* int[,] CreateTwoDimArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);

        }
    }

    return array;
}

void ShowArray (int [, ]array)
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

int [,] ChangeLines(int [,] array, int strIndex1, int strIndex2)
{
    int temp;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = array [strIndex1, j];
        array[strIndex1,j] = array[strIndex2,j];
        array[strIndex2, j] = temp;
    }

    return array;
}

int rows = 4;
int columns = 5;
int min = 1;
int max = 9;


int [,] myArray = CreateTwoDimArray (rows, columns, min, max);

ShowArray(myArray);

Console.WriteLine();

ChangeLines(myArray, 1, myArray.GetLength(0)-2);

ShowArray(myArray); */

//Задача 1 Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

/* int[,] CreateTwoDimArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);

        }
    }

    return array;
}

void ShowArray (int [, ]array)
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

int [,] RotateMatrix(int [,] array)
{
    int temp;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i+1; j < array.GetLength(1); j++)
    {
        temp = array [i, j];
        array[i,j] = array[j,i];
        array[j, i] = temp;
    }

    }
    
    return array;
}

int m, n, min, max;

do {
    Console.WriteLine ("Веедите данные. Число строк должно быть равно числу столбцов");
    m = Convert.ToInt32(Console.ReadLine());
    n = Convert.ToInt32(Console.ReadLine());
    min = Convert.ToInt32(Console.ReadLine());
    max = Convert.ToInt32(Console.ReadLine());

}
while (m != n);

int [,] myArray = CreateTwoDimArray(m, n, min, max);

ShowArray(myArray);

Console.WriteLine();

myArray = RotateMatrix(myArray);

ShowArray(myArray); */

//Задача 2. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

/* int[,] CreateTwoDimArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);

        }
    }

    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] RemoveLineAndRowWithMinElement(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;
    int min = array[minRow, minColumn];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                minRow = i;
                minColumn = j;
                min = array[i, j];
            }
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, minColumn]   = 0;
    }

    for (int j = 0; j < array.GetLength(0); j++)
        {
            array[minRow, j]   = 0;
        }


    return array;
}

int m, n, min, max;


    Console.WriteLine("Веедите данные:");
    m = Convert.ToInt32(Console.ReadLine());
    n = Convert.ToInt32(Console.ReadLine());
    min = Convert.ToInt32(Console.ReadLine());
    max = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateTwoDimArray(m, n, min, max);

ShowArray(myArray);

Console.WriteLine();

myArray = RemoveLineAndRowWithMinElement(myArray);

ShowArray(myArray);  */



int[] SorElementsFromMinToMax(int[] array)
{
    for (int k = 0; k < array.Length - 1; k++)
    {
        int minIndex = k;
        
        for (int j = k + 1; j < array.Length; j++)
            if (array[j] < array[minIndex]) minIndex = j;
        
        if (minIndex != k)
        {
            int temp = array[minIndex];
            array[minIndex] = array[k];
            array[k] = temp;
        }
        
    }
   
    return array;
}

void PrintArray(int [] array)
{
    Console.WriteLine();
    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int [] myArray = new int [] {1,2,3,9,1,4,2};

PrintArray(myArray);

myArray = SorElementsFromMinToMax(myArray);

PrintArray(myArray);