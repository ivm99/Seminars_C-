// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*double RaiseNum(int num, int degree)
{
    double result = Math.Pow(num,degree);

    return result;
}

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень: ");
int m = Convert.ToInt32(Console.ReadLine());

double res = RaiseNum(n,m);

Console.WriteLine($"{n} в степени {m} равно {res}");*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19, 3, 44, 3 -> [1, 2, 5, 7, 19, 3, 44, 3]

//Решение 1 (элементы массива генерируются случайным образом)

/*void FillArray(int [] array)
{
    for (int i=0 ; i < array.Length ; i++)
    {
        array[i] = new Random().Next(1,100);
        
    }

}

void PrintArray(int [] array)
{
    for (int i=0; i< array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

//Console.WriteLine("Введите длину массива: ");
//int l = Convert.ToInt32(Console.ReadLine());

int l = 8;

int [] newArray = new int[l];

FillArray(newArray);

PrintArray(newArray);*/

//Решение 2 (Элементы массива вводит пользователь отдельными числами)

void FillArray(int [] array)
{
    for (int i=0 ; i < array.Length ; i++)
    {
        Console.Write($"Введите {i}-й элемент: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        
    }

}

void PrintArray(int [] array)
{
    for (int i=0; i< array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Введите длину массива: ");
int l = Convert.ToInt32(Console.ReadLine());

int [] newArray = new int[l];

FillArray(newArray);

Console.Write("Ваш массив: ");
PrintArray(newArray);