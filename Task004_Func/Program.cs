/* Напишите программу вычисления функции:
 x = f(a)*/

 int F(int a)
 {
    return a*a*a-2*a*a+1;
 }

Console.WriteLine("Enter argument range: 'a' starts from>");
int a1 = int.Parse(Console.ReadLine()); //преобразование строки в целове число
Console.WriteLine("Enter argument range: 'a' ends with>");
int a2 = int.Parse(Console.ReadLine()); //преобразование строки в целове число

int i;
for(i=a1;i<=a2;i++)
{
    System.Console.WriteLine($"for a={i} x=F(a) is {F(i)}");
}
