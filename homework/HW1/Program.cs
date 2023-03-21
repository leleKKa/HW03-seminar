// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.WriteLine("Input a first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(max < num2)
{
  Console.WriteLine(max = num2);
  Console.Write("max = " + num2 + " min = "+ num1);
}
else
  Console.Write("max = " + num1 + " min = "+ num2);
*/



// Задача 4: Напишите программу, которая принимает на вход три 
// числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("Input a first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a second number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a third number");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(num1>max)
   max = num1;
if(num2>max)
  max = num2;
if(num3>max)
  max = num3;
Console.WriteLine("max = " + max);
*/



// Задача 6: Напишите программу, которая на вход принимает число 
//и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Input a number");
int num = Convert.ToInt32(Console.ReadLine());
int current = num % 2;
if(current == 0)
  Console.WriteLine("четное число");
else
  Console.WriteLine("нечетное число");
*/

  // Задача 8: Напишите программу, которая на вход принимает число (N), 
  // а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Input a positive number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = 1;
    while(current <= number)
    {
      if(current % 2 == 0)
      {
        Console.Write(current + " ");
         current++;
      }
      else
      current++;
    }
*/