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


/*
// Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
void FindMinMaxSum(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sumPositive += array[i];
        else
            sumNegative += array[i];
    }
    Console.WriteLine("Sum of negatives elements is " + sumNegative);
    Console.WriteLine("Sum of positives elements is " + sumPositive);
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
FindMinMaxSum(myArray);
*/

/*
// Задача 2. Напишите программу замены элементов массива: положительные элементы замените на 
//соответствующие отрицательные, и наоборот.


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int [] FindMinMaxSum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=(array[i]*(-1));
    }
    return array;
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
int[] pk=FindMinMaxSum(myArray);
ShowArray(pk);
*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
bool FChekNamber (int[] array, int n)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]==n)return true;  
    }
    return false;  
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Input namber N : ");
int n = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
Console.WriteLine(FChekNamber(myArray,n)); 
*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

  void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int FindSumOddNumbers (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        sum += array[i];
    }
    return sum;
}
Console.Write ("Введите длину массива: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите минимальное число массива: ");
int min = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите максимальное число массива: ");
int max = Convert.ToInt32 (Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
Console.WriteLine ($"Сумма нечетных чисел в массиве = {FindSumOddNumbers (myArray)}");
*/
/*
 
for (int i = 2; i <= 10; i++)
{
   
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
/*
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
*/
/*
int [] Creatarray (int size,int min, int max)

{
    int[] newarray=new int[size];
    for (int i = 0; i <size; i++)
    {
        newarray[i]=new Random().Next(min,max+1);  
        
    }
    return newarray; 
}

void ShowArra (int [] sharray)
{
       for (int i = 0; i < sharray.Length; i++)
        Console.Write($"{sharray[i]}  " );
        Console.WriteLine();
}

  Console.Write("Введите размер: ");
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max: ");
int max=Convert.ToInt32(Console.ReadLine());  
int [] p=Creatarray(size,min,max);
ShowArra(p);
 */
 int[,] Creatarray2 (int a, int b, int vmin, int vmax)
 {
    int [,] newarray=new int[a,b];
    for (int i = 0; i <a; i++)
    {
        for (int j = 0; j <b; j++)
        {
          newarray[i,j]=new Random().Next(vmin,vmax+1);  
        }
    }
    return newarray;
 } 

 void ShowArray2 (int[,] array)
 {
    for (int i = 0; i <array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" " );
        }
        Console.WriteLine();
    }
 }
 Console.Write("Введите колличество строк: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int b=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите элемент массива min : ");
int vmin =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент массива: ");
int vmax=Convert.ToInt32(Console.ReadLine());
int[,] p=Creatarray2(a,b,vmin,vmax);
ShowArray2(p); 