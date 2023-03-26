/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int[]CreateRandomArray(int size, int minValue, int maxValue)
{
  int[] array = new int[size];
  for(int i = 0; i < size; i++)
  {
    if (minValue >= 100 && maxValue < 1000)// нужно ли тут это условие
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
Console.WriteLine("Количество четных элементов в массиве " + result);


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
    if (i % 2 > 0) sum = sum + array [i];
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
Console.WriteLine("Сумма элементов массива, стоящих на нечетных позициях равна " + result);

*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и 
минимальным элементов массива.
[3 7 22 2 78] -> 76*/
/*
double[] array(int size, int minValue, int maxValue)
{
  double[] randomArray = new double[size];
      for (int i = 0; i < size; i++)
        {
           randomArray[i] = new Random().NextDouble()+new Random().Next(minValue, maxValue + 1);
           //Console.Write($"{randomArray[i]} ");
        }
        return randomArray;
}

void WriteArray(double[] randomArray)
{
  for(int i = 0; i < randomArray.Length; i++)
    Console.Write(randomArray[i] + " ");
    Console.WriteLine();
}

double difference(double[] randomArray)
{
  double min = randomArray [0];
  double max = randomArray [0];
  for (int i=0; i < randomArray.Length; i++)
  {
    if (max < randomArray[i]) max = randomArray[i];
    if (min > randomArray[i]) min = randomArray[i];
  }
  return max-min;
}
Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимально возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимально возможное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

double [] randomArray = array(size, min, max);

WriteArray(randomArray);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным элементом массива {difference(randomArray)}");
*/

