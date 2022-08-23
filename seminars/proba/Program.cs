/*
// // Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
int FindSum (int number)
{
    int sum=0;
    for (int i = 1; i <=number; i++)
    {
       sum=sum+i; 
    }   
    return sum;
}

Console.Write("Input a namber ");
int f =Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"sum of namber {f} = {FindSum(f)}");
*/
/*
//Задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int Count1 (int number)
{
int current=0;
while (number>0)
   {
    number = number / 10;
    current++;
   }
    return current;
   
}
Console.Write($"input a nambe: ");
int b =Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе {b} ={Count1(b)}");
*/
/*
// Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
int FindComposition (int number)
{
int pro=1;
for (int i = 1; i <= number; i++)
{
    pro=pro*i;
}
return pro;
}
Console.Write($"input a nambe: ");
int b =Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"произведения чисел от 1 до {b} ={FindComposition(b)}");
*/
/*
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
Console.Write($"input a nambeA: ");
int b =Convert.ToInt32(Console.ReadLine());
Console.Write($"input a nambeB: ");
int a =Convert.ToInt32(Console.ReadLine());

if (a>b)
Console.Write($"max={a},min={b}");
else
Console.Write($"max={b},min={a}");
*/
/*
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
Console.Write($"input a nambeA: ");
int a =Convert.ToInt32(Console.ReadLine());
Console.Write($"input a nambeB: ");
int b =Convert.ToInt32(Console.ReadLine());
Console.Write($"input a nambeA: ");
int c =Convert.ToInt32(Console.ReadLine());
int max=a;
if (b>a) 
max=b;
if (c>b)
max=c;
Console.WriteLine(max);
*/
/*
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write($"input a nambeA: ");
int a =Convert.ToInt32(Console.ReadLine());
if (a%2 == 0)
Console.Write($"четное ");
else
Console.Write($"нечет ");
*/
/*
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write($"input a nambeA: ");
int a =Convert.ToInt32(Console.ReadLine());
int current=2;
while (current<=a)
{
    Console.Write(current + " " );
    current+=2;
}

*/
/*
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.



int Secon (int namber)
{
    namber=(namber/10)%10;
    return namber;
}
Console.Write($"input a nambeA: ");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Secon(a));
*/
/*
//Задача 25: Напишите цикл, который принимает
//на вход два числа (A и B) и 
//возводит число A в натуральную степень B.

int Steprn (int A, int B)
{
    int stp=1;
    for (int i = 0; i < B; i++)
    {
        stp=A*stp;
    }
    return stp;
}
Console.Write("Inputa namber A ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Inputa namber B ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Steprn(a,b)}");
*/
// Задача №1. Напишите программу, которая выводит случайное число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

/*
int Findbigest (int namber)
{
    int ed=namber%10;
    int dec=namber/10;
    int max;
    if(ed>dec)
    max=ed;
    else
    max=dec;
    return max;
}
Console.WriteLine("Некотороу двухзначное рандомное число");
int randomNumber = new Random().Next(10,100);
Console.WriteLine($" {randomNumber} is {Findbigest(randomNumber)}" );
*/


// Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
   { 
    Console.Write("Input size for array: ");
    newArray[i] = Convert.ToInt32(Console.ReadLine());
   }
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
Console.WriteLine();
ShowArray(myArray);

    for (int j = 2; j <= 10; j++)
    {
     Console.WriteLine($"{i}*{j}={i*j}");
     
    }
    Console.WriteLine();
}

*/
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int [,] array (int a,int b, int min, int max )
{
    int [,] newarray = new int[a,b];
    for (int i = 0; i < a; i++)
    {
      for (int j = 0; j <b; j++)
      {
          newarray[i,j]=new Random().Next(min,max+1);
      }
    } 
    return newarray;
}
void ShowArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        Console.Write($"{array[i,j]} "); 
        
      } 
      Console.WriteLine();
    }
    
}
Console.Write("Введите колличество строк: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int b=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите элемент массива min : ");
int min =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int max=Convert.ToInt32(Console.ReadLine());
int[,] p=array(a,b,min,max);
ShowArray(p); 