/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

Console.Write("Введите пятизначное число:");
int Value = Convert.ToInt32(Console.ReadLine());

void Number(int num)
{
    int Length = num.ToString().Length;
    if (Length == 5) 
  {
    int firstNum = num/10000;
    int secondNum = num/1000%10;
    int fourthNum = num%100/10;
    int fifthNum = num%10;
    if (firstNum == fifthNum && secondNum == fourthNum) 
    {
      Console.WriteLine("Число является палиндромом");
    }  
	  else 
    {
      Console.WriteLine("Число не является палиндромом");
    }
  }
    else Console.WriteLine("Задано не пятизначное число");
}
Number(Value);*/

 
/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

double twoPoints (double x1, double y1, double z1, double x2, double y2, double z2)
{
   double firstN = Math.Pow(x2-x1, 2);
   double secondN = Math.Pow(y2-y1, 2);
   double thirdN = Math.Pow(z2-z1, 2);
   double sum = firstN + secondN + thirdN;
   double result = Math.Sqrt(sum);
   return Math.Round(result,2);
}

Console.WriteLine("Введите координату числа x1");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату числа y1");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату числа z1");
double num3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату числа x2");
double num4 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату числа y2");
double num5 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату числа z2");
double num6 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Длина отрезка = " + twoPoints(num1, num2, num3, num4, num5, num6));


/* Задача 23
Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

int Number(int num)
{
  int current = 1;
  while(current<=num)
  {
    int result = current*current*current; //
    current++;
    Console.Write($"{result} ");
  }
  return current;
}

Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

int result1 = Number(number);
Console.Write($"Ряд кубов чисел от 1 до {number}");*/

