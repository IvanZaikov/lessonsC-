 
 /*
 //Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
 
 double[,] Creatarray2 (int a, int b, int vmin, int vmax)
 {
    double [,] newarray=new double[a,b];
    for (int i = 0; i <a; i++)
    {
        for (int j = 0; j <b; j++)
        {
          newarray[i,j]=Math.Round(Convert.ToDouble(new Random().Next(vmin, vmax )) + new Random().NextDouble(), 2);
        }
    }
    return newarray;
 } 
 void ShowArray2 (double[,] array)
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
double[,] p=Creatarray2(a,b,vmin,vmax);
ShowArray2(p); 
*/
/*
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
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
void FindNamber (int[,] Array,int findrows, int findcolumns)
{
 if(findrows>Array.GetLength(0)|| findcolumns>Array.GetLength(1))
 Console.WriteLine("числа с таким индексом нет"); 
 else Console.WriteLine($"Число равно {Array[findrows-1,findcolumns-1]}");
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
 Console.Write("Введите номер строки: ");
int s=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int st=Convert.ToInt32(Console.ReadLine());
FindNamber(p,s,st);
*/
/*
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
double [] Arithmetic(int[,] array)
{
    double[] starray = new double [array.GetLength(1)];
    for (int j = 0; j <array.GetLength(1) ; j++)
    {
        double sum=0;
        double count=0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
           sum+=array[i,j];
           count++;
           starray[j]= Math.Round((sum/count),2);
        }       
    }
    return starray;  
}
void ShowArra (double [] sharray)
{
       for (int i = 0; i < sharray.Length; i++)
        Console.Write($"{sharray[i]}  " );
        Console.WriteLine();
}
Console.Write("Введите количество строк: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива: ");
int vmin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int vmax = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Creatarray2(a, b, vmin, vmax);
ShowArray2(myArray);
double [] arr =Arithmetic(myArray);
ShowArra(arr);
*/