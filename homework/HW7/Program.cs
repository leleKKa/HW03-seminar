/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */
/*
double[,] CreateRandom2dArray()
{
  Console.Write("Введите количество строк: ");
  int rows = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите количество столбцов: ");
  int columns = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите минимальный элемент: ");
  int minValue = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите максимальный элемент: ");
  int maxValue = Convert.ToInt32(Console.ReadLine());
     

  double[,] randomArray = new double[rows, columns];
      for (int i = 0; i < rows; i++) 
        for (int j = 0; j < columns; j++)
        {
           randomArray[i,j] = Math.Round((new Random().NextDouble()+new Random().Next(minValue, maxValue + 1)),2);
           //Console.Write($"{randomArray[i,j]} ");
        }
        return randomArray;
}

void WriteArray(double[,] randomArray)
{
  for (int i = 0; i < randomArray.GetLength(0); i++) // 0 номер элемента в создании массива
    {
        for (int j = 0; j <  randomArray.GetLength(1); j++)
        Console.Write(randomArray[i,j] + " ");
        Console.WriteLine();
    }
  Console.WriteLine();
}

double[,] myArray = CreateRandom2dArray();
WriteArray(myArray); 
*/
/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> числа с такими индексами в массиве нет */
/*
int[,] CreateRandom2dArray()

{
  Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
          array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Write2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
  Console.WriteLine();
}

void FindOut(int[,] array, int numA, int numB)
{  
  if (numA < array.GetLength(0) && numB < array.GetLength(1)) 
  Console.WriteLine($"Элемент массива с индексами строки {numA} и столбца {numB} число {array[numA, numB]}");
  else
  Console.WriteLine("такого числа нет");
}

int[,] myArray = CreateRandom2dArray();
Write2dArray(myArray); 

Console.WriteLine("Введите идекс строки ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите идекс столбца ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

FindOut(myArray, numA, numB);
*/
/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] CreateRandom2dArray()

{
  Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
          array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Write2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
  Console.WriteLine();
}

double[] FindArrayAverage(int[,] array)
{
      double[] average = new double[array.GetLength(1)];
      for (int j = 0; j<array.GetLength(1); j++)
      { 
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
          sum = sum + array[i,j];
          average[j] = sum/array.GetLength(0);
      }
      return average;
}

void WriteArray(double[] average)
{
  for(int i = 0; i < average.Length; i++)
    Console.Write(average[i] + " ");
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Write2dArray(myArray);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое столбцов из массива");
double[] average = FindArrayAverage(myArray);
WriteArray(average);


