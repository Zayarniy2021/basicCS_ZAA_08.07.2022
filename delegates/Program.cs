//Подсчитать количество латинских маленьких букв в строке
//Подсчитать количество латинских больших букв в строке
//Подсчитать количество цифр в строке


//Вариант с делегатом
namespace Zayarniy
{
    class Program
    {
        delegate bool IsChar(char c);//описали шаблон делегата bool(char)

        static bool IsLatinSmall(char c)
        {
            if (c>='a' && c<='z') return true; else return false;
        }

        static bool IsLatinBig(char c)
        {
            if (c>='A' && c<='Z') return true; else return false;
        }

        static int CountChars(string s,IsChar isChar)
        {
            int k=0;
            for(int i=0;i<s.Length;i++)
                if (isChar(s[i])) k++;
            return k;
        }

        static void Main()
        {

            string[] ss=Console.ReadLine().Split(' ');
            int[] aa=Array.ConvertAll<string, int>(ss,Convert.ToInt32);
            double[] aa2=Array.ConvertAll<string, double>(ss,Convert.ToDouble);






















            IsChar isChar=new IsChar(IsLatinSmall);            
            string s="It's string contains BIG LATIN CHARS, small latin chars and digits(1234567890)";
            //System.Console.WriteLine(CountChars(s, isChar));
            System.Console.WriteLine(CountChars(s, 
            delegate(char c)//анониманый делегат
            {
                return (c>='A' && c<='Z');
            }));
            //Лямбда-выражения
            System.Console.WriteLine(CountChars(s, 
            (c)=>(c>='A' && c<='Z')
            ));
        }

    }
}



/*

//Вариант без делегатов



//Подсчитать количество латинских маленьких букв в строке
int CountCharLatSmall(string s)
{
    int k=0;
    for(int i=0;i<s.Length;i++)
        if (s[i]>='a' && s[i]<='z') k++;
    return k;
}


//Подсчитать количество латинских больших букв в строке
int CountCharLatBig(string s)
{
    int k=0;
    for(int i=0;i<s.Length;i++)
        if (s[i]>='A' && s[i]<='Z') k++;
    return k;
}

//Подсчитать количество цифр в строке
int CountCharDigit(string s)
{
    int k=0;
    for(int i=0;i<s.Length;i++)
        //if (s[i]>='0' && s[i]<='9') k++;
        if (char.IsDigit(s[i])) k++;
    return k;
}




string s="It's string contains BIG LATIN CHARS, small latin chars and digits(1234567890)";
System.Console.WriteLine(CountCharDigit(s));
System.Console.WriteLine(CountCharLatBig(s));
System.Console.WriteLine(CountCharLatSmall(s));


















int k1,k2,k3;
CountCharAll(s,out k1,out k2,out k3);


















void CountCharAll(string s,out int k1,out int k2,out int k3)

{
    k1=0;
    k2=0;
    k3=0;
    for(int i=0;i<s.Length;i++)
    {
        if (s[i]>='a' && s[i]<='z') k1++;
        if (s[i]>='A' && s[i]<='Z') k2++;
        if (char.IsDigit(s[i])) k3++;
    }
    
}
*/