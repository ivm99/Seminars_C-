/*int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }

    Console.WriteLine();

    return newArray;
}

int FindPositiveSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += array[i];

    }

    return sum;
}

int FindNegativeSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i];

    }
    return sum;
}

Console.WriteLine("Input length of array: ");

int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min value: ");

int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max value: ");

int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(length, min, max);

Console.WriteLine("Sum of positive numbers is " + FindPositiveSum(myArray));

Console.WriteLine("Sum of negative numbers is " + FindNegativeSum(myArray));*/

//Задача 1. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

/*int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }

    Console.WriteLine();

    return newArray;
}

int[] ChangePosNeg(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
        Console.Write(array[i] + " ");
    }
    return array;

}

int[] newArray2 = CreateRandomArray(10, -10, 10);
newArray2 = ChangePosNeg(newArray2);*/

// Задача 2. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

/*int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }

    Console.WriteLine();

    return newArray;
}

bool CheckNum(int [] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    
    }
    return false;
}

int [] array = CreateRandomArray(10,-10,10);
int num = 5;
Console.WriteLine(CheckNum(array, num));*/

//Задача 3. Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }

    Console.WriteLine();

    return newArray;
}

int CountNumbers(int [] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >=min && array[i]<=max) count ++;
    }
    return count;
}

int min2 = 10;
int max2 = 99;
int [] array2 = CreateRandomArray(12, 0, 20);
Console.WriteLine(CountNumbers(array2, min2, max2));
