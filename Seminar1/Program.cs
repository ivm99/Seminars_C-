﻿/*int num, result;

Console.Write("Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

result = num * num;

Console.WriteLine("Result is " + result);
*/


/* Задача 2

int num1, num2, quad;

Console.Write("Input first number ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number ");
num2 = Convert.ToInt32(Console.ReadLine());

quad = num2 * num2;

if (num1 == quad)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}*/

int num;

Console.Write("Input number ");
num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while (current <= num)
{
    Console.Write(current + " ");
    current ++; // current = current +1
}

