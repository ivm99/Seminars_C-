// Задача 1 Разворот массива

/* int [] ReverseArray(int [] array)
{
    int temp;
    int j = array.Length-1;

    for (int i = 0; i < array.Length/2; i++, j--)
    {
        temp = array[i];
        array[i] = array [j];
        array[j] = temp;
        
    }

    return array;
}

int [] myArray = {2,4,6,8,10,12};

myArray = ReverseArray(myArray);

Console.Write("{ ");

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}

Console.Write("}"); */

//Задача 1. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

//(Сумма любых двух сторон должны быть больше третьей)

/* bool CheckTriangle(int a, int b, int c)
{
    if (a+b >c && b+c > a && a+c > b) return true;

    return false;
}

Console.Write("Введите сторону А: ");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите сторону B: ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите сторону C: ");
int c1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckTriangle(a1,b1,c1)); */



//Задача 2. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

//0 1 1 2    3   5    8
//0 1 2     i - 2  i - 1   i

/* int[] GetFibonacci(int n)
{
    int [] fibonacci = new int[n];
    
    fibonacci[0] = 0;
    fibonacci[1] = 1;

    Console.Write(fibonacci[0] + " ");
    Console.Write(fibonacci[1] + " ");

    for (int i = 2; i < n; i++)
    {
        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        Console.Write(fibonacci[i] + " ");
    }

    return fibonacci;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

GetFibonacci(number);
 */

//Задача 3 Напишите программу, которая будет преобразовывать десятичное число в двоичное.

/* int[] ConvertDecToDvoich(int n)
{
    int ost = n;
    int size = 0;
    int[] array = new int[size];
    int i = 0;
    

    while (ost > 0)
    {
        size++;
        Array.Resize(ref array, size);
        array[i] = ost % 2;
        ost = ost / 2;
        i++;
        
       
    }
    return array;
}

int[] ReverseArray(int[] array)
{
    int temp;
    int j = array.Length - 1;

    for (int i = 0; i < array.Length / 2; i++, j--)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;

    }

    return array;
}

int number = 10;

int[] myArray = ConvertDecToDvoich(number);
ReverseArray(myArray);

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}
 */

string ConvertToBinar(int n)
{
    string binar = String.Empty;
    int ost = n;

    while (ost > 0 )
    {
        binar = ost%2 + binar;
        ost = ost / 2;
    }
    return binar;
}

int num = 100;

Console.WriteLine(ConvertToBinar(num));
