// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

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

