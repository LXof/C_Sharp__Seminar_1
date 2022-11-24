// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
Console.Clear();
Console.WriteLine("Введите три числа");
Console.Write("a = ");
int numA = int.Parse(Console.ReadLine());
Console.Write("b = ");
int numB = int.Parse(Console.ReadLine());
Console.Write("c = ");
int numC = int.Parse(Console.ReadLine());
int max = 1;

if ((numA >= numB) && (numA >= numC))
{
    max = numA;
} else 
    if ((numB >= numA) && (numB >= numC))
    {
        max = numB;
    } else 
        max = numC;

Console.WriteLine($"max = {max}");

