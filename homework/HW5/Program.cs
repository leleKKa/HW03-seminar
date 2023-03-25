/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
/*
int[]CreateRandomArray(int size, int minValue, int maxValue)
{
  int[] array = new int[size];
  for(int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(minValue, maxValue + 1);
  }
  return array;
}

void WriteArray(int[] array)
{
  for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

int Number(int[] array)
{
  int count = 0;
  for (int i=0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0) count++;
  }
  return count;
}
 
Console.Write("Введите длину массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(Length, min, max);
WriteArray(myArray);


int result = Number(myArray);
Console.WriteLine("Количество четных элементов в массиве " + result);*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

/*
int[]CreateRandomArray(int size, int minValue, int maxValue)
{
  int[] array = new int[size];
  for(int i = 0; i < size; i++)
  {
    array[i] = new Random().Next(minValue, maxValue + 1);
  }
  return array;
}

void WriteArray(int[] array)
{
  for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

int sum(int[] array)
{
  int sum = 0;
  for (int i=0; i < array.Length; i++)
  {
    if (array[i] % 2 >0) sum = sum + array [i];
  }
  return sum;
}
 
Console.Write("Введите длину массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(Length, min, max);
WriteArray(myArray);

int result = sum(myArray);
Console.WriteLine("Сумма нечетных элементов массива равна " + result);
*/



/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76*/
