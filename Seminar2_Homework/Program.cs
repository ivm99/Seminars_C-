/* Задача 1: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.*/

/*int Cut3to1( int num )
{
    int dec = num / 10 % 10;
    return dec;
}

Console.Write("Input three-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a >=100 && a<=999) Console.WriteLine("Second digit is " + Cut3to1(a));
else Console.WriteLine("The number is not a three-digit");*/

/* Задача 2: Напишите программу, которая выводит
случайное трёхзначное число и удаляет вторую цифру
этого числа.*/

/*int Delete2ndFrom3()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine(num);
    int sot = num /100;
    int ed = num % 10;
    return sot*10+ed;
}

Console.WriteLine(Delete2ndFrom3());*/

/*Задача 3: Напишите программу, которая выводит третью
цифру заданного числа или сообщает, что третьей цифры
нет.*/

/*int OutputThirdNumber(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }

    int thirdNumber = num % 10;

    return thirdNumber;
}

Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());

int moduleA = Math.Abs(a);

if (moduleA >= 100) Console.WriteLine(OutputThirdNumber(moduleA));
else Console.WriteLine("There is no third digit in the number");*/

/*Задача 4: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.*/

bool CheckDay(int day)
{
    if (day == 6 || day == 7) return true;
    else return false;
}

Console.Write("Input day of week number (1,2,...7): ");
int weekDay = Convert.ToInt32(Console.ReadLine());

if (weekDay >= 1 && weekDay <= 7)
{
    if (CheckDay(weekDay))
    {
        Console.WriteLine("Yes :)");
    }
    else
    {
        Console.WriteLine("No :(");
    }
}
else
{
    Console.WriteLine("Invalid number");
}
