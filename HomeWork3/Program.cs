// Задача №1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
string Palindrome(int num)
{
    string result;
    string numString = Convert.ToString(num);
    if (numString.Length == 5)
    {
        char one = numString[0];
        char two = numString[1];
        char four = numString[3];
        char five = numString[4];
        if (one == five && two == four)
            result = $"number{num} - palindrome";
        else
            result = $"number{num} - is not palindrome";
    }
    else
        result = "enter a five-digit number";
        return result;
}
Console.Write("enter a five-digit number");
int num = Convert.ToInt32(Console.ReadLine());
string result = Palindrome(num);
Console.WriteLine(result);
*/

// Задача №2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double FindDistance(double xa, double ya, double za, double xb, double yb, double zb)
{
    double distance = Math.Sqrt(Math.Pow((xb-xa), 2) + Math.Pow((yb-ya),2) + Math.Pow((zb-za),2));
    return distance;
}
Console.Write("Input xa-coordinate: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input ya-coordinate: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input za-coordinate: ");
double za = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xb-coordinate: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yb-coordinate: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zb-coordinate: ");
double zb = Convert.ToDouble(Console.ReadLine());


double distance = FindDistance(xa, ya, za ,xb, yb, zb);
double Distance = Math.Round(distance, 2);
Console.WriteLine($"distance between point A {xa}, {xb}, {za} and point B {ya}, {yb}, {zb} = {Distance}");
*/
// Задача №3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
/*
void WriteQ(int n)
{
    int count = 1;
    while(count <= n)
    {
        Console.WriteLine(Math.Pow(count,3));
        count++;
    }
}
Console.WriteLine("Input N number");
int n = Convert.ToInt32(Console.ReadLine());
WriteQ(n);
*/