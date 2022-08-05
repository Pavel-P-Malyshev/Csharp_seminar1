/*Напишите программу, которая на вход 
принимает число и выдаёт его квадрат (число 
умноженное на само себя).
*/
Console.WriteLine("Enter any integer number:");
int N = int.Parse(Console.ReadLine()); //преобразование строки в целове число

//Console.Write("Square of your number is:");
//Console.WriteLine(N*N);

Console.Write($"Square of your number is:{N*N}");

