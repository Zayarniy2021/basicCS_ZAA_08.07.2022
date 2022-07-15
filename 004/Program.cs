//По заданному с клавиатуры номеру дня недели вывести его название
int dayOfWeek;//camelCase 
//int DayOfWeek;//PascalCase
//dayOfWeek=Convert.ToInt32(Console.ReadLine());
dayOfWeek=Convert.ToInt32(Console.ReadLine());

//if (dayOfWeek==1) System.Console.WriteLine("Monday");    
//if (dayOfWeek==2) System.Console.WriteLine("Tuesday");
        

switch(dayOfWeek)
{
    case 1:
        System.Console.WriteLine("Monday");
        break;
    case 2:
        System.Console.WriteLine("Tuesday");
        break;
    case 3:
        System.Console.WriteLine("Wednesday");
        break;
    default:
        System.Console.WriteLine("Wrong!");
        break;
}