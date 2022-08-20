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

/*
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет
// количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int[] CreateRandomArray1(int size)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(100, 1000);
    return newArray;
}
int Chetnii (int []array)
{
       int count=0;
       for (int i = 0; i < array.Length; i++)
       {
        if (array[i]%2==0) count++;
       }
       return count; 
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray1 (a);
ShowArray(myArray);
int result = Chetnii(myArray);
Console.WriteLine($"Количество чётных чисел в массиве равно {result}");
*/
/*
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int Sumarray (int[] array)
{
    int Sum=0;
    for (int i = 1; i < array.Length; i+=2)
    {
        Sum=array[i]+Sum;
    }
    return Sum;
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
int result = Sumarray(myArray);

Console.WriteLine($"сумму элементов, стоящих на нечётных позициях  равно {result}");
*/
/*
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int DifMaxMin (int[] array )
{
    int max=array[0];
    int min=array[0];
    int difference=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max)
        max=array[i];
        if (array[i]<min)
        min=array[i];
    }
      difference=(max-min); 
    return (difference);
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
int result = DifMaxMin(myArray);
Console.WriteLine($"diffence betwin max element and min elemant array  is {result}");
*/