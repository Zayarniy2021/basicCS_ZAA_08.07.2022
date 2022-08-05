//На стандартном потоке ввода задаются два целых числа.
// На стандартный поток вывода напечатайте сумму этих чисел.
//1
//1
//2

using System;
/*
int a=int.Parse(Console.ReadLine());
int b=int.Parse(Console.ReadLine());
System.Console.WriteLine(a+b);
*/
string s=Console.ReadLine();
string[] ss=s.Split(' ');
int a=int.Parse(ss[0]);
int b=int.Parse(ss[1]);
int c=int.Parse(ss[2]);

System.Console.WriteLine(a+b+c);