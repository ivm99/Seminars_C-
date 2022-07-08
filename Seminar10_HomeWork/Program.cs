// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1


/* string [] CreateSrtingArray(int size)
{
    string [] array = new string [size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите элемент {i}: ");
        array[i] = Console.ReadLine();
    }

    return array;
}

int CountWordsGlasn(string [] array)
{
    int count = 0;

    char [] glasn = {'a', 'e', 'i', 'o', 'u'};
    
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < glasn.Length; j++)
        {
            if (char.ToLower(array[i][0]) == glasn[j]) count++;
        }
        
    }

    return count;
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string [] array = CreateSrtingArray(n);

Console.WriteLine($"Количество слов, начинающихся с гласной буквы, равно {CountWordsGlasn(array)}"); */


// __________________________________________________________________________________________________________________________________

// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}


string[] CreateSrtingArray(int size)
{
    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите элемент {i}: ");
        array[i] = Console.ReadLine();
    }

    return array;
}

void ShowArray(string[] array)
{
    Console.WriteLine();

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i] + " ");
    }

    Console.WriteLine();
}

string[] CombinePairs(string[] array)
{


    if (array.Length % 2 == 1)
        Array.Resize(ref array, array.Length + 1);

    string[] newArray = new string[array.Length];

    for (int i = 0; i < array.Length / 2; i++)
    {
        newArray[i] = array[i * 2] + array[i * 2 + 1];
    }

    return newArray;
}

Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = CreateSrtingArray(n);

ShowArray(CombinePairs(array));