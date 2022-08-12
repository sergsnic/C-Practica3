// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Write("Введите число: ");
string? numeric = Console.ReadLine();
Console.Write(numeric);
if( numeric[0].Equals( '-' )  ) numeric = numeric.TrimStart('-');
bool flag = false;
for (int i = 0; i < numeric.Length; i++)
    if (!numeric[i].Equals(numeric[numeric.Length-1-i])) flag = true;
if (flag == true) Console.WriteLine(" не является палиндромом.");
else Console.WriteLine(" является палиндромом.");
