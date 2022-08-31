// Задача 19

//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
/*
void A(int a1) //a1-данное число,  
{ 
   int a2; //a2-левые два числа,
    a2 = a1/1000;
    //Console.WriteLine($"левые два числа: {a2}");
    int a3 = a1%10; // a3-последнее число
    int a4 = a1%100/10;  //a4-предпоследнее число
    int a5 = a3*10+ a4;    //a5-правые два числа наоборот
   // Console.WriteLine($"правые два числа: {a5}");
   if (a2==a5)
   {
    Console.WriteLine("да ");
   }
   else
   {
    Console.WriteLine("нет ");
   }
}
Console.WriteLine("Введите пятизначное число: ");
int a1 = Convert.ToInt32(Console.ReadLine());
A(a1);
*/

//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double A(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double dx = x1-x2;
    double dy  = y1-y2;
    double dz = z1-z2;
    double d = Math.Sqrt(dx*dx+dy*dy+dz*dz);
    return d ;
}
Console.WriteLine("Введите коорд т1 x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коорд т1 y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коорд т1 z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коорд т2 x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коорд т2 y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коорд т2 z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
double N = A(x1,x2,y1,y2,z1,z2);
Console.WriteLine($"длина отрезка {N}");
*/

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void A (int n)
{
    int i=1;
    while (i<=n)
    {
        int s;
        s = i*i*i;

        Console.WriteLine( i + " в кубе равно :" + s);
        i ++;
    }
}
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
A(N);
