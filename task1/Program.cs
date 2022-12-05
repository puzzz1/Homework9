/*Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму
 натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

void resultNumber(int m, int n, int result)
{
    if (m > n)
    {
        Console.WriteLine($"(Sum of numbers {result})");
        return;
    }
    result = result + (m++);
    resultNumber(m,n,result);
}

Console.Write(" Put First Number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" Put Second Number: ");
int n = Convert.ToInt32(Console.ReadLine());
resultNumber (m,n,0);