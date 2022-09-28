/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void PrintData(string prefix, string value)
{
    Console.WriteLine(prefix + value);
}

string PolyTest(int num)
{
    if (num / 10000 == num % 10 && (num / 1000) % 10 == (num / 10) % 10)
        return "Число полиндром";
    else
    {
        return "Число не полиндром";
    }
}
int number = ReadData("Введите 5-ти значное число ");
if (number >= 10000 && number < 100000)
{
    PrintData(PolyTest(number), "");
}
else
{
    PrintData("Вы ввели не 5-ти значное число", "");
}

