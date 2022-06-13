//Задача 1
/*int FindQuart (int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;

    return -1;
}

int result = FindQuart(6,-5);

if (result == -1)
{
    Console.WriteLine("Данная точка расположена на осях");
}
else
{
    Console.WriteLine($"Точка находится в {result} четверти");
}*/

//Задача 1

/*void DefineRange (string quater)
{
    if (quater == "1") 
    {
        Console.WriteLine("x > 0, y > 0");
    }
     if (quater == "2") 
    {
        Console.WriteLine("x < 0, y > 0");
    }
     if (quater == "3") 
    {
        Console.WriteLine("x < 0, y < 0");
    }
     if (quater == "4") 
    {
        Console.WriteLine("x > 0, y < 0");
    }
}

Console.Write("Введите номер четверти: ");
string a = Console.ReadLine();

if (a == "1" || a == "2" || a =="3" || a == "4")
{
    DefineRange(a);
}
else
{
    Console.WriteLine("Wrong number");
}*/

//Задача 2

/*void Square (int n)
{
    int index = 1;
    while (index <= Math.Abs(n))
    {
        Console.Write(index*index + " ");
        index++;
    }
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Square(num);*/

//Задача 3

double FindLength(double xA, double yA, double xB, double yB)
{
    return Math.Sqrt((xB - xA)*(xB - xA) + Math.Pow((yB - yA),2));
}

Console.WriteLine("Введите кооддинату X первой точки: ");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кооддинату Y первой точки: ");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кооддинату X второй точки: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кооддинату Y второй точки: ");
int b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Длина отрезка = {FindLength(a1,a2,b1,b2)}");
