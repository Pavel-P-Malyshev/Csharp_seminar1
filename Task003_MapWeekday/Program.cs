/*Напишите программу, которая будет выдавать 
название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница
*/
Console.WriteLine("Enter number of a week day from 1 to 7");
int wd = int.Parse(Console.ReadLine()); //преобразование строки в целове число
string[] wd_name={"Mon","Tue","Wed","Thu","Fri","Sat","Sun"};

Console.Write ($"Your day of week is called '{wd_name[wd-1]}'");


