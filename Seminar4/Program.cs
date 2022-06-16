//Задача 1 Вернуть сумму цифр заданного числа

/*int FindSumOfDigits(int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum = sum + num % 10; // то же самое sum += num % 10
        num = num /10; // то же самое num /=10
    }

    return sum;
}
int n = 234;
int result = FindSumOfDigits(n);

Console.WriteLine($"Сумма цифр в числе {n} = {result}");*/

//Задача 2 Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

/*int Sum(int num)
{
    int sum = 0;
    int count = 0;

    while (count <= num)
    {
        sum += count;
        count ++;
    }

    return sum;
}
int n = Convert.ToInt32(Console.ReadLine());
int result = Sum(n);

Console.WriteLine($"Сумма чисел от 1 до {n} = {result}");*/

//Задача 3 Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

/*int Proiz(int num)
{
    int proiz = 1;
    int count = 1;

    while (count <= num)
    {
        proiz = proiz * count;
        count ++;
    }

    return proiz;
}
int n = Convert.ToInt32(Console.ReadLine());
int result = Proiz(n);

Console.WriteLine($"Произведение чисел от 1 до {n} = {result}");*/

//Задача 4. Напишите программу, которая принимает на вход число и выдаёт кол-во цифр в числе.

/*void Count(int a)
{
    int counter = 0;
    while (a > 0)
    {
        a = a / 10;
        counter++;
    }
    Console.WriteLine("Count of digits in your number is: " + counter);
}
int b = Convert.ToInt32(Console.ReadLine());
Count(b);*/

