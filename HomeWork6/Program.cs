// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
int AmountPositiveNums(int amountNum)
{
    int count = 0; 
    for(int i = 1; i <= amountNum; i++)
    {
        Console.Write("Input  a number: ");
        double num = Convert.ToDouble(Console.ReadLine());
        if(num>0) count++;
    }
    return count;
}
int AmountPositiveNums(int amountNum)
{
    int amount = 0;
    int count = 0;
    do
    {
        Console.Write("Input  a number: ");
        double num = Convert.ToDouble(Console.ReadLine());
        if (num > 0) count++;
        amount++;
    } while (amount < amountNum);
    return count;
}
/*
Console.Write("Input the desired number of numbers: ");
int amountNum = Convert.ToInt32(Console.ReadLine());
int result = AmountPositiveNums(amountNum);
Console.WriteLine($"Number of positive numbers = {result}");
*/

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*
double[] IntersectionLines(double b1, double k1, double b2, double k2)
{
    double[] array = new double[2];
    array[0] = (b2-b1)/(k1-k2);
    array[1] = k1 * array[0] + b1;
    return array;
}
void PrintIntersection(double[] array)
{
    Console.Write($"Intersection point = [{array[0]}; {array[1]}].");
}
/*
Console.Write("Input a b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
if(k1 == k2) Console.WriteLine("Lines are parallel, there is no point of intersection.");
else
{
    double[] result = IntersectionLines(b1,k1,b2,k2);
    PrintIntersection(result);
}
*/