// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8

/* int[,] CreateMatrix(int m, int n, int min, int max)
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

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] SortRowElementsFromMinToMax(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            int minIndex = k;
            
            for (int j = k + 1; j < array.GetLength(1); j++)
            {
                if (array[i, j] < array[i,minIndex]) minIndex = j;
            }
            if (minIndex != k)
            {
                int temp = array[i, k];
                array[i, k] = array[i, minIndex];
                array[i, minIndex] = temp;
            }
        }

    }

    return array;
}


Console.WriteLine("Введите число строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент: ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateMatrix(rows, columns, min, max);

PrintArray(myArray);

myArray = SortRowElementsFromMinToMax(myArray);

PrintArray(myArray); */


// _____________________________________________________________________________________________________________________________________

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/* int[,] CreateMatrix(int m, int n, int min, int max)
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

void PrintMatrix(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PrintArray(int [] array)
{
     Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
       
    }
}

int [] GetSumArray(int [,] array )
{
    int [] sumArray = new int [array.GetLength(0)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumArray [i] = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArray[i] += array[i,j]; 
        }

    }

    return sumArray;
}


int FindLineWithMinSum(int [] array )
{
    int minRowIndex = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[minRowIndex]) minRowIndex = i;
    }

    return minRowIndex;
}

Console.WriteLine("Введите число строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальный элемент: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальный элемент: ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateMatrix(rows, columns, min, max);

PrintMatrix(myArray);

int [] sumArray = GetSumArray(myArray);

Console.Write("Суммы по строкам равны: ");

PrintArray(sumArray);

int minLineIndex = FindLineWithMinSum(sumArray);

Console.WriteLine();

Console.Write("Номер строки с минимальной суммой: " + minLineIndex); */


//Console.WriteLine ($"Индекс строки с минимальной суммой: {minLineSumIndex}");

//_________________________________________________________________________________________________________________________________________

// Задача 62. Заполните спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 1 2 3 4

// 12 13 14 5

// 11 16 15 6

// 10 9 8 7

int[,] FillSpiralArray(int n) // мое решение
{
    int[,] array = new int[n, n];

    int count = 1;

    int k = 0;

    while (count <= n*n && k <= n/2)
    {

        for (int j = k; j < n - 1 - k; j++) // 1-я линия - движение вправо
        {
            array[k, j] = count;
            count++;
        }



        for (int i = k; i < n - 1 - k; i++) // 2-я линия - движение вниз
        {
            array[i, n - 1 - k] = count;
            count++;
        }



        for (int j = n - 1 - k; j > k; j--) // 3-я линия - движение влево
        {
            array[n - 1 - k, j] = count;
            count++;
        }



        for (int i = n - 1 - k; i > k; i--) // 4-я линия - движение вверх
        {
            array[i, k] = count;
            count++;
        }


        k++;

    }

    if (n % 2 !=0) array [n/2,n/2] = count;

    return array;
}

int[,] FillSpiralArray2() // не мое решение (нашел в интернете)
{
int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

return sqareMatrix;

}

void PrintMatrix(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите размер квадратной матрицы: ");

int size = Convert.ToInt32(Console.ReadLine());

int[,] myArray = FillSpiralArray(size);

PrintMatrix(myArray);
