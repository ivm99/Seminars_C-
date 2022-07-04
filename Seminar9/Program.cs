//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

/* void ShowNums(int n)
{
    if (n != 1)
        ShowNums(n - 1);

    Console.Write(n + " ");
}

Console.Write("Input integer positive number: ");

int num = Convert.ToInt32(Console.ReadLine());

ShowNums(num); */

//___________________________________________________________________________________________________________________

//Задача 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// void ShowNunFromNToM(int n, int m)
// {
//     if (m != n)
//     {
//         ShowNunFromNToM(n, m-1);
//     }

//     Console.Write(m + " ");
// }

// ShowNunFromNToM(3, 10);
// _______________________________________________________________________________________________________________________

//Задача 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

/* int FindSum(int num)
{
    if (num / 10 > 0)
    
      return FindSum(num / 10)+num%10;
     
    
    return num;
}

int n = 1234;

int summa = FindSum(n);

Console.WriteLine(summa); */

// _______________________________________________________________________________________________________________________

//Задача 3. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int FindDegree(int a, int b)
{
    if (b>0)
    {
        return FindDegree(a,b-1)*a;
    
    }
    else
       if (b == 0) return 1;
       else return -1;

}

int a = 2;

int b = 6;

int result = FindDegree(a,b);

Console.WriteLine(result);