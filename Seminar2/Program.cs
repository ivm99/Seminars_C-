 //Пример 1
 
 /*int FindMaxPart(int num)
 {
     int dec, ed;

      if (num >=10 && num <=99)
       {
           dec = num /10;
           ed = num % 10;

           if (dec > ed)
           {
                return dec;
            }
            else
            {
                return ed;
            }
        }
        else
        {
            return -1;
        }
 }


Console.WriteLine("Input two-digit number: ");
int a = Convert.ToInt32(Console.Read());
int result = FindMaxPart(a);

if (result == -1)
{
    Console.WriteLine("Your number is not a two-digit");
}
    
else
{
    Console.WriteLine("Bigger number of " + a + " is " + result);
}*/

//Задача 1


/*int CutNumber()
{
    int sot, dec, ed, newNum;

    int num = new Random().Next(100, 1000);

    Console.WriteLine(num);
   
    ed = num % 10;

    dec = num % 100 / 10;

    sot = num / 100;

    newNum = sot*10 + ed;

    return newNum; 

    

}

int a = CutNumber();

Console.WriteLine(a);*/

//Задача 2

/*string CheckEven(int num1, int num2)
{
   if (num2 % num1 == 0) return "True";
   else return "False, rest number " + (num2%num1);
}

Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());

string c = CheckEven(a, b);
Console.WriteLine(c);*/

//Задача 3

bool CheckEven7and23(int num)
{
    if ((num%7==0) && (num%23==0)) return true;
    else return false;
}

Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());


if (CheckEven7and23(a)) Console.WriteLine("Число кратно 7 и 23 одновременно");
else Console.WriteLine($"Число не кратно 7 и 23 одновременно. Остаток от деления: {a/(23*7)}");
