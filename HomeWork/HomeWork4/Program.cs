/*
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Degree (int A, int B)
{    int deg =1;
       for (int i = 1; i <= B; i++)
   {
     deg=deg*A;
   }
return deg;
}
Console.Write ("Input a namber A: ");
int A = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Input a namber B: ");
int B = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine( Degree(A,B));
*/

/*

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int Sumdigit (int namber)
{
    int r =0;
    int sum=0;
   while( namber>0)
    {
        r=namber%10;
        sum=r+sum;
        namber=namber/10;
    }
    return sum;
}
Console.Write ("Input a namber : ");
int B = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine( Sumdigit(B));
*/

/*
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int [] CreateRandomArray(int size)
{
    int[] newArray = new int [size];
    
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Enter an array element");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
        
    }
    return newArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}
Console.Write ("Enter the length of the array: ");
int a = Convert.ToInt32 (Console.ReadLine());
int[] myArray = CreateRandomArray (a);
ShowArray(myArray);
*/