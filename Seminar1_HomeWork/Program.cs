//Задача №1

/*Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("max = " + num1);
    Console.WriteLine("min = " + num2);
}
else
{
    Console.WriteLine("max = " + num2);
    Console.WriteLine("min = " + num1);
}*/

//Задача №2

/*Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number:");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;

if (num3 > max) max = num3;

Console.WriteLine("max = " + max);*/

//Задача №3

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

double chastnoe = num % 2;

if (chastnoe == 0)
{
    Console.WriteLine("number is even");
}
else
{
    Console.WriteLine("number is uneven");
}