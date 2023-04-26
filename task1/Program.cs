// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine()); 
string len = a.ToString();
int l = len.Length;

if (l == 5)
{
    if (len[0] == len[4] && len[1] == len[3])
    {
        Console.WriteLine("полиндром");
    }
    else
    {
        Console.WriteLine("не полиндром");
    }
}
else
{
    Console.WriteLine("изучите что такое пятизначное число!");
}
