//18. По двум заданным числам проверять является ли одно квадратом другого. 
//Используйте подпрограмму.

bool Check(int a, int b)
{
    return a*a==b || b*b==a;
}

//ОСНОВНАЯ ПРОГРАММА
//int s=Sum(2,2);//Вызов подпрограммы
//System.Console.WriteLine(Sum(2,4));
//Pause();
int a=25;
int b=5;
if (Check(a,b))
{
    System.Console.WriteLine("Является");
}
else
{
    System.Console.WriteLine("Не является");
}







//Сумма двух чисел
int Sum(int a,int b)
{
    //тело подпрограммы
    return a+b;
}

void Pause()
{   
    Console.ReadKey();
}