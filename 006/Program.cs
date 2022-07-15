//6. Написать программу вычисления значения функции y = sin(a). (Класс Math)

//double x=3.14;
double x=Math.PI;
double y=Math.Sin(x);
double y1=Math.Sin(x*2);
System.Console.WriteLine($"{y:G}");
System.Console.WriteLine(9.0/100000000.0);
if (Math.Abs(y-y1)<=1E-10) System.Console.WriteLine("OK");
else System.Console.WriteLine("Wrong");