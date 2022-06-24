// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

/* int CountPositiv(string numbers)
{
    int count = 0;
    string[] separateNumbers = numbers.Split(',',' ');

    for (int i = 0; i < separateNumbers.Length; i++)
    {
        int temp = Convert.ToInt32(separateNumbers[i]);
        if (temp > 0) count++;
    }
    return count;

}

Console.Write("Введите числа через запятую или пробел: ");
string nums = Console.ReadLine();

int totalPositiv = CountPositiv(nums);

Console.WriteLine($"Количество положительных чисел в данной последовательности: {totalPositiv}"); */




// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


//Решение1

/* char [] MakeArrayCopy(string array)
{
    char [] newArray = new char [array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        newArray [i] = array [i];
        Console.Write(newArray[i]);
    }

    return newArray;
}

Console.Write("Введите массив: ");
string myArray = Console.ReadLine();

Console.WriteLine();
Console.Write("Копия введенного массива: ");
MakeArrayCopy(myArray); */

//Решение 2

int [] InputArray(int size)
{
    int []array = new int [size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array [i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

void PrintArray(int [] array)
{
    Console.WriteLine();
    Console.Write("Введенный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int [] CopyArray (int [] array)
{
    int [] arrayCopy = new int [array.Length];
        
    Console.WriteLine();
    Console.Write("Копия вашего массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
        Console.Write(arrayCopy[i] + " ");
    }

    return arrayCopy;
}

Console.Write("Введите длину массива: ");
int l = Convert.ToInt32(Console.ReadLine());

int [] myArray = InputArray(l);

PrintArray(myArray);

CopyArray(myArray);


