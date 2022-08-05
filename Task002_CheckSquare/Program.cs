/*Напишите программу, которая на вход принимает два 
числа и проверяет, является ли первое число квадратом 
второго.
a = 5; b = 25 -> да 
a = 2 b = 10 -> нет 
a = 9; b = -3 -> нет 
a = -3 b = 9 -> да
*/
Console.WriteLine("Enter any integer number1:");
int X = int.Parse(Console.ReadLine()); //преобразование строки в целове число
Console.WriteLine("Enter any integer number2:");
int Y = int.Parse(Console.ReadLine()); //преобразование строки в целове число

if (X*X==Y) {Console.Write($"Yeah, your number2 <{Y}> is square of your number1 <{X}>");}
else {Console.Write($"Sorry, your number2 <{Y}> is NOT square of your number1 <{X}>");}


