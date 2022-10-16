// Задача №1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int DegreeTwoNumber(int a, int b)
{
    int result = a;

    for(int current = 1; current <= (b-1); current++)
        result *= a;
    return result;    
}

Console.Write("Input the number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number b: ");
int b = Convert.ToInt32(Console.ReadLine());
int degreeTwoNumber = DegreeTwoNumber(a,b);
Console.WriteLine($"Number {a} to the degree of {b} = {degreeTwoNumber}");
*/

//Задача №2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}

Console.WriteLine("Input the number ");
int num = Convert.ToInt32(Console.ReadLine());
int sumDigits = SumDigits(num);
Console.WriteLine($"The sum of the digits in a number {num} = {sumDigits}");
*/

// Задача №3. Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
int[] CreateArray(int size)
{
    while(size < 0)
    {
        Console.Write("The size of an array cannot be a negative number! Input the positive number: ");
        size = Convert.ToInt32(Console.ReadLine());
    }
    int[] array = new int[size];
    if(size == 0) 
        Console.WriteLine("Array size = 0, array is empty.");
    else
    {
        for(int i = 0; i < size; i++)
        {
            Console.Write("Input the array element: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return array; 
}
void ShowArray(int [] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
        Console.Write(newArray[i] + " ");
    Console.WriteLine();
}
Console.Write("Input the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] YourArray = CreateArray(size);
Console.ForegroundColor = ConsoleColor.Green;
ShowArray(YourArray);
*/
