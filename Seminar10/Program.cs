/*string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words[i] = Console.ReadLine();

    }
    return words;
}

void ShowArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    } 

    Console.WriteLine();
}

int NumberOfLongWords (string [] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length>=5)
        {
            count++;
        }
    }
    return count;
}


Console.Write("Input number of names:");

int size = Convert.ToInt32(Console.ReadLine());

string[] names = CreateStringArray(size);

Console.WriteLine("Number of long words is "+ NumberOfLongWords(names)); */

//______________________________________________________________________________________________________________________________________

//Задача 1. Написать программу, которая принимает на вход два массива строк и возвращает массив из попарно объединенных исходных элементов.

/* string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words[i] = Console.ReadLine();

    }
    return words;
}

void ShowArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    } 

    Console.WriteLine();
}

string [] CombineArrays(string [] array1, string [] array2)
{
    if (array1.Length > array2.Length)
    {
        for (int i = 0; i < array2.Length; i++)
        {
            array1[i] = array1[i] + " " + array2[i];
        }

        return array1;
    }
    else
    {
        for (int i = 0; i < array1.Length; i++)
        {
            array2[i] = array2[i] + " " + array1[i];
        }

        return array2;
    }

}

Console.Write("Введите количество элементов первого массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов второго массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string [] array1 = CreateStringArray(m);

string [] array2 = CreateStringArray(n);

ShowArray(CombineArrays(array1, array2)); */


//______________________________________________________________________________________________________________________________________

//Задача 2. 2. Написать программу, которая считает кол-во слов, начинающихся на букву Y или W.

string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words[i] = Console.ReadLine();

    }
    return words;
}

int CountWordsWithFirstSymbol(string [] array, char symbol1, char symbol2)
{
    int count = 0;

    symbol1 = char.ToLower(symbol1);
    symbol2 = char.ToLower(symbol2);

    for (int i = 0; i < array.Length; i++)
    {
        if (char.ToLower(array[i][0]) == symbol1 || char.ToLower(array[i][0]) == symbol2)
            count++;
    }

    return count;
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первую букву: ");
char a = Convert.ToChar(Console.ReadLine());

Console.Write("Введите вторую букву: ");
char b = Convert.ToChar(Console.ReadLine());

string [] array = CreateStringArray(n);

Console.WriteLine($"Количество слов, начинающихся с буквы {a} или {b} равно {CountWordsWithFirstSymbol(array,a,b)}");

