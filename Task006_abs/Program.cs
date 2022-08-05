/*. Напишите программу вычисления модуля числа.
2 -> 2
-3 -> 3
-7 -> 7
**. Напишите программу, которая на вход принимает значение, а 
на выходе показывает обратное значение.
1 -> 1 
2 -> 0.5
0.25 -> 4

*/
Console.WriteLine("Enter any integer number:");
int N = int.Parse(Console.ReadLine()); //преобразование строки в целове число


Console.WriteLine($"For you number the absolute value is {Math.Abs(N)}");
Console.WriteLine($" The -1 power  of your number is {(double)1/N}");

