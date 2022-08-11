
/*
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа


int CutNumber(int number)

{
    int dec = (number % 100)/10;
       return dec;
}

Console.Write("input a three-digit number: ");
int n =Convert.ToInt32(Console.ReadLine());
int dec2=CutNumber(n);
Console.WriteLine($"second namber of namber {n} is {dec2}");

*/

/*
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int FindNumber1(int number)
{
while (number>=1000)
number=number/10;
return number;
}
Console.Write("input a number: ");
int n =Convert.ToInt32(Console.ReadLine());
int ThirdNamber=FindNumber1(n);
if (n<=99)
{
Console.WriteLine($"Number {n}  had't third namber ");
}
else
{
ThirdNamber=ThirdNamber%10;
Console.WriteLine($"three-digit number: of {n} is {ThirdNamber}");
}
*/
/*
// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

void Dennedeli (int namber)
{
if (namber <=5)
Console.WriteLine("workin day");
else 
Console.WriteLine("weekend");
}

Console.Write("enter a number from 1 to 7: ");
int n =Convert.ToInt32(Console.ReadLine());
Dennedeli(n);
*/