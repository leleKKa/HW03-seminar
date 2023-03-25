// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
/*
int Number(int num)
{
	int secondNum = 0;
	if (num >=100 && num <1000)
	secondNum = num/10%10;
	return secondNum;
}

void CheckNumber(int num)
{
	if(num < 100 || num >= 1000) Console.WriteLine("Введите другое число");
	else Console.WriteLine($"Вторая цифра в заданном числе {Number(num)}");
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

CheckNumber(num);
*/

    //Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
   // и проверяет, является ли этот день выходным.

/*Console.Write("Enter a day of week ");
int Day = Convert.ToInt32(Console.ReadLine());

void DayOfWeek (int number)
{
	if (number >=1 && number < 6) Console.WriteLine("День рабочий");
	else if (number >=6 && number <8) Console.WriteLine("Выходной");
	else Console.WriteLine("Это не день недели");
}

DayOfWeek(Day);*/
 

// Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

/*
int Number(int num)
{
	int result = 0;
	while (num > 999) num = num / 10;
	result = num % 10;
	return result;
}

void CheckNumber (int num)
{
	if(num < 100) Console.WriteLine("Введите другое число");
	else Console.WriteLine($"Третья цифра в заданном числе {Number(num)}");
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

CheckNumber(num);
*/
