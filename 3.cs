//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день
// недели, и проверяет, является ли этот день выходным.

using static System.Console;
Clear();

bool isHoliday(int day) { return day>5 ? true : false; }
int day;
do
{
    Write("Enter a number for the day of the week: ");
    day = int.Parse(ReadLine());
} while (day > 7||day<1);

Write($"Is this day off? ");
if (isHoliday(day)) Write("Yes");
else Write("No.");