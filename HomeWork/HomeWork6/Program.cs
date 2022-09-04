// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
int array (int[] newarray )
{
    int count=0;
    for (int i = 0; i < newarray.Length; i++)
    {
    if (newarray[i]>0) count++;
    }
    return count;
}    
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

 Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
int p =array(myArray);
Console.WriteLine(p);
*/
/*
int array (int[] newarray )
{
    int count=0;
    for (int i = 0; i < newarray.Length; i++)
    {
    if (newarray[i]>0) count++;
    }
    return count;
}    
int [] CreatArray (int M)
{
    int [] array=new int[M]; 
    for (int i = 0; i< M; i++)
    {
    Console.Write($"Введите {i+1} число: ");
    int a = Convert.ToInt32(Console.ReadLine());  
        array[i]=a;
    }
    return array;
}
 
Console.Write("Сколько чисел будите вводить?: ");
int M = Convert.ToInt32(Console.ReadLine());  
int[] myArray = CreatArray (M);
int p =array(myArray);
Console.WriteLine(p);
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
void Metod(double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    Console.WriteLine($"({x},{y})");
}
Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Metod(b1, k1, b2, k2);
*/
/*
int [] Creatarray (int size, int min, int max)
{
    int []array= new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i]=new Random().Next(min,max);
    }
    return array;

}
void ShowArra (int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}
Console.Write("input size array " );
int size=Convert.ToInt32(Console.ReadLine());
Console.Write("input min valei array ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max valei array ");
int max =Convert.ToInt32(Console.ReadLine());
Creatarray(size,min,max);
ShowArra(Creatarray(size,min,max));
*/
/*
int [,] CreatArray2 (int s, int st, int min, int max)
{
    int [,]array=new int[s,st];
    for (int i = 0; i < s; i++)
    {
        for (int j = 0; j < st; j++)
        {
            array[i,j]=new Random().Next(min,max);
        }
    }
    return array;
}
void ShowArra2 (int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
           
        }
         Console.WriteLine();
    }
}
Console.Write("input s array ");
int s=Convert.ToInt32(Console.ReadLine());
Console.Write("input st array ");
int st=Convert.ToInt32(Console.ReadLine());
Console.Write("input min alement array ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("input max alement array ");
int max = Convert.ToInt32(Console.ReadLine());
CreatArray2(s,st,min,max);
ShowArra2(CreatArray2(s,st,min,max));
*/








