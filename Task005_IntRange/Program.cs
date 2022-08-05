/*Напишите программу, которая на вход принимает одно число 
(N), а на выходе показывает все целые числа в промежутке от -N 
до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"

*/
Console.WriteLine("Enter any integer number:");
int N = int.Parse(Console.ReadLine()); //преобразование строки в целове число
int i;

Console.WriteLine("For you number the range is");

for (i=-N;i<=N;i++)
{
   Console.WriteLine(i);
 
}

