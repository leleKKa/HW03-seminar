/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
*/
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

int [,] NewOrder (int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        { 
          for (int k = 0; k < array.GetLength(1)-1; k++)
          {
            if (array[i, k] < array[i, k+1])
            {
            int temp = array[i,k+1];
            array[i,k+1] = array[i,k];
            array[i,k]= temp;
            }
          }
        }
    }  
return array;
}

int[,] myArray = CreateRandom2dArray();
Write2dArray(myArray);
int[,] arr = NewOrder(myArray);
Write2dArray(arr);
*/

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка 
*/
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

int[] FindArraySum(int[,] array)
{
      int[] arraySum = new int[array.GetLength(0)];
      for (int i = 0; i<array.GetLength(0); i++)
      {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sum = sum + array[i,j];
            arraySum[i] = sum;
      }
      return arraySum;
}

void WriteArray(int[] array)
{
  for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

int NumberLine(int[] arraySum)
{
    int min = arraySum [0];
    int numberOfLine = 0;
    for (int i = 0; i < arraySum.Length; i++)
    {
      if (min > arraySum[i])
      {
          min = arraySum[i];
          numberOfLine = i;
      }
    }
    return numberOfLine;
}

int[,] myArray = CreateRandom2dArray();
Write2dArray(myArray);
Console.WriteLine();
int[] arraySum = FindArraySum(myArray);
WriteArray(arraySum);
int min = NumberLine(arraySum);
Console.WriteLine("Номер индекса строки с минимальной суммой элементов " + min);
*/

//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandomdArray1(int rows1, int columns1rows2, int minValue, int maxValue)
{
    int[,] array = new int[rows1, columns1rows2];

    for (int i = 0; i < rows1; i++)
        for (int j = 0; j < columns1rows2; j++)
          array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

int[,] CreateRandomdArray2(int columns1rows2, int columns2, int minValue, int maxValue)
{
    int[,] array = new int[columns1rows2, columns2];

    for (int i = 0; i < columns1rows2; i++)
        for (int j = 0; j < columns2; j++)
          array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

Console.Write("Введите количество строк 1 матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов 1 матрицы и строк 2 матрицы: ");
int columns1rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 2 матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

void WritedArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <  array.GetLength(1); j++)
        Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
  Console.WriteLine();
}

int[,]SumMatrix(int[,]matrix1, int[,] matrix2)
{
  int [,] sumArray = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
  
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
          int sum = 0;
          for (int k = 0; k < matrix1.GetLength(1); k++)
          {
            sum += matrix1[i,k] * matrix2[k,j];
          }
            sumArray[i,j] = sum;
        }
    }
  return sumArray;
}

int[,] matrix1 = CreateRandomdArray1(rows1, columns1rows2, minValue, maxValue);
WritedArray(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateRandomdArray2(columns1rows2, columns2, minValue, maxValue);
WritedArray(matrix2);
int[,] matrix3 = SumMatrix(matrix1,matrix2);
WritedArray(matrix3);
*/

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] CreateRandom2dArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    int num = 10;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
          for (int k = 0; k < z; k++)
          {
          array[i, j, k] = num;
          num++;
          }
        }
    }
    return array;
}


void Write2dArray(int[,,] array, int x, int y, int z)
{
  if (x * y * z <= 90)
  {
    for (int k = 0; k < array.GetLength(2); k++)
    {
      Console.WriteLine($"{k}");
      for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j <  array.GetLength(1); j++)
        {
        Console.Write($"{array[i,j,k]} ({i}, {j}, {k})");
        Console.WriteLine();
        }
    }
  }
  else Console.WriteLine("Введите другие значения x, y, z");
}


Console.Write("Введите количество строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Bедите количество z: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] myArray = CreateRandom2dArray(x,y,z);
Write2dArray(myArray, x, y, z);
Console.WriteLine();

