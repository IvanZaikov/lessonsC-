/*
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


bool Polinom1 (int number)
{
    int ed=number%10;
    int dec=(number%100)/10;
    int tis=(number/1000)%10;
    int dti=number/10000; 
    return dti==ed && tis==dec;
      
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
bool N = Polinom1(n);
Console.WriteLine(N);
*/

/*
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84 A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double Findlt (double X1,double Y1, double Z1, double X2, double Y2, double Z2)
{
double len = Math.Sqrt(Math.Pow(X2-X1,2) + Math.Pow(Y2-Y1,2) + Math.Pow(Z2-Z1,2));
return len;
}

Console.Write ("input the cardinate x of the point A ");
double xA = Convert.ToDouble (Console.ReadLine());
Console.Write ("input the cardinate y of the point A ");
double yA = Convert.ToDouble (Console.ReadLine());
Console.Write ("input the cardinate z of the point A ");
double zA = Convert.ToDouble (Console.ReadLine());
Console.Write ("input the cardinate x of the point A ");
double xB = Convert.ToDouble (Console.ReadLine());
Console.Write ("input the cardinate y of the point A ");
double yB = Convert.ToDouble (Console.ReadLine());
Console.Write ("input the cardinate z of the point A ");
double zB = Convert.ToDouble (Console.ReadLine());
double l= Findlt(xA,yA,zA,xB,yB,zB);
Console.Write($"distance between the points is equal to {l}");
*/

/*
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void  FindCube (int namb)
{
    int current=1;
    while (current<=namb)
    {
         Console.WriteLine($"Cube{current}={current*current*current}: ");
     current ++;
    }
}
Console.Write("Input a namber: ");
int N = Convert.ToInt32(Console.ReadLine());
FindCube(N);
*/
