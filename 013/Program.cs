//13. Удалить вторую цифру с начало целого числа введенного с клавиатуры.

int a=Convert.ToInt32(Console.ReadLine());
int d0=a%10;
int na=a/100;
a=na*10+d0;
System.Console.WriteLine(a);
//123=13
