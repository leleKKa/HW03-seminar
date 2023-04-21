// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
/*
void CrossPoint (double numK1, double numB1, double numK2, double numB2)
{
      if (numK1 == numK2) 
      {
         if(numB1 == numB2) Console.WriteLine("Прямые совпадают");
         else Console.WriteLine("Прямые параллельны");
      }
      else 
      {
        double pointX = 0;
        double pointY = 0;
        pointX = (numB2 - numB1)/(numK1-numK2);
        pointY = numK1*pointX + numB1;
        Console.WriteLine($"Точка пересечения двух прямых вида y=k*x+b имеет координаты x = {pointX} и y = {pointY}");
      }
}

Console.WriteLine("Введите число k1: ");
double numK1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b1: ");
double numB1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
double numK2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2: ");
double numB2 = Convert.ToDouble(Console.ReadLine());

CrossPoint(numK1, numB1, numK2, numB2);
*/
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*Console.WriteLine("Введите ряд чисел: ");
string? name = Console.ReadLine();
Console.WriteLine($"{name}");

Console.WriteLine("Введите строку:");
string? input = Console.ReadLine();
 
bool result = int.TryParse(name, out var number);
if (result == true)
    Console.WriteLine($"Преобразование прошло успешно. Число: {number}");
else
    Console.WriteLine("Преобразование завершилось неудачно");
*/
string? s = Console.ReadLine();
if (int.TryParse(s, out int i))
    Console.WriteLine("Число, увеличенное на 5: {0}", i + 5);
else
    Console.WriteLine("Введенная строка не являлась числом.");