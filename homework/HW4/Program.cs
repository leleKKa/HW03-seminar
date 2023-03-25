/* 
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/
/*

int NumberInDeegree(int numA, int numB)
{
    int deegree = 0;
    if(numB < 0)
    {
      deegree = -1*numB;
    }
    else 
    {
      deegree = numB;
    }
    

  int result = 1;
  {
  for (int current = 0; current < deegree; current++)
      result *= numA; 
      return result;
  }
}

Console.WriteLine("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

int FinishResult = NumberInDeegree(numA, numB);
Console.WriteLine("число в степени "+ FinishResult);*/


/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

/*
int Number(int num)
{  
  int newNum = 0;
    if(num < 0)
    {
      newNum = -1*num;
    }
    else 
    {
      newNum = num;
    }
  
  int result = 0;
     while (newNum > 0)
      { 
          result = result + newNum % 10;
          newNum = newNum/10;
      }
        return result;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Result = Number(num);
Console.WriteLine("сумма цифр из числа "+ Result);
*/


/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; // new int[размер] - эта констуркция позволяет инициализировать массив

    for (int index = 0; index < size; index++)
    {
        array[index] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ " ");
    }

    Console. WriteLine();
}

Console.Write("Введите длину массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(Length, min, max);
WriteArray(myArray);
