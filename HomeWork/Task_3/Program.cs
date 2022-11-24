// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if ((num % 2) == 0) 
{
    Console.WriteLine($"{num} - четное");
} else
    Console.WriteLine($"{num} - нечетное");
