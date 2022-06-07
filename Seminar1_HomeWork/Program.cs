//Задача №1

Console.Write("Input first number: ");
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
}