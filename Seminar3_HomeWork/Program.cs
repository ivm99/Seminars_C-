//Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да

/*void CheckPalindrom(int anyNumber)
{
    if (anyNumber >= 10000 && anyNumber <= 99999)
    {
        int razr1 = anyNumber % 10;
        int razr2 = anyNumber / 10 % 10;
        int razr3 = anyNumber / 100 % 10;
        int razr4 = anyNumber / 1000 % 10;
        int razr5 = anyNumber / 10000;

        if (razr1 == razr5 && razr2 == razr4)
        {
            Console.WriteLine($"The number {anyNumber} is Palindrom");
        }
        else
        {
            Console.WriteLine($"The number {anyNumber} is not Palindrom");
        }

        //Console.WriteLine($"{razr5} {razr4} {razr3} {razr2} {razr1}");
    }
    else
    {
        Console.WriteLine($"Number {anyNumber} doesn't suit requirement");
    }
}

Console.Write("Input positive five-digit number: ");

int n = Convert.ToInt32(Console.ReadLine());

CheckPalindrom(n);*/

//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53

/*double FindDistance(int xA, int yA, int zA, int xB, int yB, int zB)
{
    return Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA), 2));
}

Console.Write("Input xA: ");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input yA: ");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input zA: ");
int a3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input xB: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input yB: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input zB: ");
int b3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Distance between point A and point B = {FindDistance(a1,a2,a3,b1,b2,b3)}");*/

//Задача 23

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void Cube(int n)
{
    int index = 1;

    if (n > 0)
    {
        while (index <= n)
        {
            Console.Write(Math.Pow(index, 3) + " ");
            index++;

        }
    }
    else
    {
        Console.WriteLine("Wrong number");
    }
}

Console.Write("Input positive number: ");
int number = Convert.ToInt32(Console.ReadLine());

Cube(number);