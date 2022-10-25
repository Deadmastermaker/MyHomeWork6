// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
double UserNum (double number)
{
    double count = 0;
    for(double i = 1; i <= number; i++)
    {
    Console.Write("Input num: ");
    double num = Convert.Todouble(Console.ReadLine());
    if(num > 0) count++;
    }
    return count;
}

Console.Write("How much numbers: ");
double number = Convert.Todouble(Console.ReadLine());
double res = UserNum(number);
Console.WriteLine($"{res}");

*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*
void MyRes (double b1, double k1, double b2, double k2)
{

    if (k1==k2 && b1 == b2) Console.WriteLine("!!!");
    else
        {
        double x = (b1 - b2) / (k2 -k1);
        double y = (k2 * x + b2);
        Console.WriteLine($"{x} , {y}");
        }
}

Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

MyRes(b1,k1,b2,k2);

*/