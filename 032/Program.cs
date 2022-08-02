//Задать массив из 8 целых элементов и вывести их на экран

//Инициализация переменных
int[] a;

//Ввод данных
Init(out a,max:100);
//Обработка данных

//Вывод результатов
Print(a);


void Init(out int[] a,int Length=10,int min=0,int max=10)
{
    a=new int[Length];
    Random random=new Random();//псевдослучайные числа
    for(int i=0;i<a.Length;i++)
            a[i]=random.Next(min,max+1);
}


void Print(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i],4}");
}










/*//значимые типы (value types)
int a=3;
double b=4;
float c;
bool bl;
c=3.14F;


//ссылочные типы (reference types)
string s=null;
s="Hellowsadfsadfasdfasdf";
string s1=s;
int[] ar;
Random random;
random=new Random();
Random random1;
random1=random;

ar=new int[20000];
int[] ar2;
ar2=ar;

*/