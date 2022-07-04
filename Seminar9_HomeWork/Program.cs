// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/* int GetSumBetweenNandM(int m, int n)
{
    if (n > m)
        return n + GetSumBetweenNandM(m, n - 1);

    return m;
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = GetSumBetweenNandM(m, n);

Console.WriteLine($"Сумма чисел от {m} до {n} равна {result}"); */



//______________________________________________________________________________________________________________________________

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.

// 453 -> 3

// 45 -> 2

int CountDigits(int num)
{
    
    if (num/10>0)
        return CountDigits(num/10)+1;
        
    return 1;
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = CountDigits(n);

Console.WriteLine($"Количество цифр в числе {n} равно {result}");