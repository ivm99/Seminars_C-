//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

/*int[] CreateNewArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);

        Console.Write(newArray[i] + " ");
    }

    return newArray;

}

int CountEvenNumber (int [] array)
{
    int count = 0;

    for (int i=0; i<array.Length; i++)
    {
        if (array[i]%2 == 0) count ++;
    }
    return count;
}
Console.Write("Задайте длину массива: ");

int size = Convert.ToInt32(Console.ReadLine());

int min = 100;
int max = 999;

int[] array = CreateNewArray(size, min, max);
int count = CountEvenNumber(array);
Console.WriteLine();

Console.WriteLine($"В данном массиве количество четных чисел: {count}");*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

/*int [] CreateNewArray (int size, int min, int max)
{
    int [] newArray = new int [size];

    for (int i=0; i<size; i++)
    {
        newArray [i] = new Random().Next(min, max+1);
        Console.Write(newArray[i] + " ");
    }
    return newArray;

}

int FindSumUnevenPosition(int [] array )
{
    int sum = 0;

    Console.WriteLine();

    Console.Write("Элементы на нечетных позициях массива:");

    for (int i=1; i<array.Length; i+=2)
    {
        sum+=array[i];

        Console.Write(array[i] +" ");
    }
    return sum;
}

Console.Write("Задайте длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 1;
int max = 100;

int[] array = CreateNewArray(size, min, max);

int sum = FindSumUnevenPosition(array);

Console.WriteLine();

Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях массива, равна {sum}");*/

//Задача 38: Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

double [] CreateNewArray(int size, double min, double max)
{
    double [] newArray = new double [size];

    for (int i=0; i<size; i++)
    {
        newArray[i] = Math.Round(new Random().NextDouble() * (max-min) + min,2);

        Console.Write(newArray[i] + " ");
    }
    return newArray;

}

double FindDifMaxMin(double []array)
{
    double max = array[0];
    double min = array[0];

    for (int i=1; i<array.Length; i++)
    {
        if (array[i] >max) max = array[i];

        if (array[i] < min) min = array[i];
    }
    
    Console.WriteLine();
    Console.WriteLine ($"Max = {max}");
    Console.WriteLine ($"Min = {min}");

    double dif = Math.Round(max - min,2);

    return dif;
    
}

Console.Write("Задайте длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double min = -100;
double max = 100;

double[] array = CreateNewArray(size, min, max);

double dif = FindDifMaxMin(array);

Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {dif}");

