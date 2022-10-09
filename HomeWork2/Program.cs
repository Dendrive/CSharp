/*
// Задача №1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int OneDigitNumber(int num)
{
    int result;

    result = num / 10 % 10;

    return result; 
}

Console.WriteLine("Введите число от 100 до 1000: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = OneDigitNumber(number);
Console.WriteLine($"Вторая цифра числа {number} -> {result}."); 
*/

/*
// Задача №2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int ThirdDigit(int num)
{
    int result = 0;

    if (num >= 100 & num <= 1000)
    result = num % 10;
    else
        if (num >= 1000 & num <= 10000)
        result = num / 10 % 10;
    else 
        if (num >= 10000 & num <= 100000) 
        result = num / 100 % 10;
        return result;
}

Console.WriteLine("Введите число от 1 до 100000");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 1 & num <= 99)
Console.WriteLine("Третьей цифры нет"); 
else
{
    int result = ThirdDigit(num);
    Console.WriteLine($"Полученное число = {num}, третья цифра в данном числе = {result}");
}
*/

/*
// Задача №3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string FindWeekend(int day)
{
    string result;
    if(day <= 5)
        result = "это рабочий день";
    else 
        result = "это выходной день";

    return result; 
}

Console.WriteLine("Введите цифру, обозначающая день недели, где понедельник - 1, воскресение 7: ");
int day = Convert.ToInt32(Console.ReadLine());
string result = FindWeekend(day);
Console.WriteLine(result);
*/