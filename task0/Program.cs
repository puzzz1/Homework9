/*Задача 64: Задайте значение N. 
Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1.
 Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int getUserInt(string message)
{
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine(message);
    Console.ResetColor();
    int UserInt = Convert.ToInt32(Console.ReadLine());
    return UserInt;
}
int userStartIndex = getUserInt("Put max element");
printRange(userStartIndex);

void printRange(int index)
{
    if (index !=0)
    {
        Console.Write(index + ", ");// если наоборот очередь
        printRange(index-1);  // поменять местаии
    }
        
}