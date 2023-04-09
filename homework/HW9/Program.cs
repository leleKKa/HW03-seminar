/* 
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
void NatureNum (int N)
{
  if(N > 1)
  {
     Console.Write(N + " ");
     NatureNum(N-1);
  }
  if (N <= 0) 
     Console.WriteLine("Введите другое число");
}

Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
NatureNum(N);
*/
/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int Sum (int M, int N)
{
  if (M <= N) return Sum (M+1, N) + M;  
  return 0;
}

void Answer(int M,int N)
{
  if(M<=0 || N<+0) Console.WriteLine("Введите натуральные числа");
else if (M >0 && N > 0) Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна {Sum(M,N)}");
}

Console.WriteLine("Введите число M ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
Answer(M,N);
*/

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/*
int Ackerman (int m, int n)
{  
  if (m == 0) return n+1;
  if (n == 0) return Ackerman (m-1,1);
  if (m > 0 && n> 0) return Ackerman(m-1,Ackerman(m,n-1));
  return 0;
}

void Answer (int m, int n)
{
  if (m<0 || n<0) Console.WriteLine("Одно из чисел или оба отрицательны, введите числа больше ноля");
  else if(m >= 0 && n >=0) Console.WriteLine($"Функция Аккермана равна {Ackerman(m,n)}");
}

Console.WriteLine("Введите число m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n ");
int n = Convert.ToInt32(Console.ReadLine());
Answer(m,n);
*/
